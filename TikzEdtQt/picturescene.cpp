#include "picturescene.h"

PictureScene::PictureScene(QObject *parent) :
    QGraphicsScene(parent)
{
    pdfView = new QGraphicsPixmapItem();
    this->addItem(pdfView);
}


void PictureScene::onPdfImageReady(const QPixmap &pic)
{
    pdfView->setPixmap(pic);
}
