#include "pdfimageprovider.h"
#include <QImage>


PdfImageProvider PdfImageProvider::Instance;

PdfImageProvider::PdfImageProvider(QObject *parent) :
    QObject(parent)
{
    doc = 0;
    theresolution=72;
    document_id = 0;
}

PdfImageProvider::~PdfImageProvider()
{
    delete doc;
}

Poppler::Document *PdfImageProvider::document()
{
    return doc;
}

qreal PdfImageProvider::resolution() const
{
    return theresolution;
}

void PdfImageProvider::render()
{
    if (doc)
    {

        QImage image = doc->page(0)
                      ->renderToImage(theresolution, theresolution);

        image.save("test.png");

        emit pixmapReady(QPixmap::fromImage(image));
        emit statusMessage("rendered pdf", false);
    }
    else
    {

        //emit pixmapReady(QPixmap::fromImage(image));
    }
}

bool PdfImageProvider::setDocument(const QString &filePath)
{
    Poppler::Document *oldDocument = doc;

    emit statusMessage("setting pdf doc: "+filePath, false);

    doc = Poppler::Document::load(filePath);
    if (doc) {
        delete oldDocument;
        doc->setRenderHint(Poppler::Document::Antialiasing);
        doc->setRenderHint(Poppler::Document::TextAntialiasing);

        render();
    }
    return doc != 0;
}

void PdfImageProvider::setDocumentId(int id)
{
    if (document_id != id)
    {
        document_id = id;

        // display blank until pdf arrives
        if (doc)
        {
            delete doc;
            doc = 0;
            render();
        }
    }
}

void PdfImageProvider::pdfReady(CompilationResult res)
{
    //if (res.job.document_id == document_id)
        setDocument(res.outFile);

    emit statusMessage("Received Pdf ready.", false);
}

void PdfImageProvider::setResolution(qreal resolution)
{
    if (theresolution != resolution) {
        theresolution = resolution;
        render();
    }
}
