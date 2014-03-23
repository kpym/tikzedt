#ifndef PDFIMAGEPROVIDER_H
#define PDFIMAGEPROVIDER_H

#include <poppler-qt5.h>

#include <QObject>
#include <QPixmap>
#include "texcompiler.h"

class PdfImageProvider : public QObject
{
    Q_OBJECT
public:
    explicit PdfImageProvider(QObject *parent = 0);
    ~PdfImageProvider();
    Poppler::Document *document();
    qreal resolution() const;

    static PdfImageProvider Instance;

signals:
    void pixmapReady(const QPixmap &pixmap);
    void statusMessage(QString text, bool isError);

public slots:
    bool setDocument(const QString &filePath);
    void setResolution(qreal resolution);
    void setDocumentId(int id);
    void pdfReady(CompilationResult res);

protected:
    void showPage(int page = -1);
    void render();

    Poppler::Document *doc;
    qreal theresolution;
    int document_id;
};

#endif // PDFIMAGEPROVIDER_H
