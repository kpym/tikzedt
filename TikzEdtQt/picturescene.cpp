#include "picturescene.h"
#include <QGraphicsRectItem>

PictureScene::PictureScene(QObject *parent) :
    QGraphicsScene(parent)
{
    //setSceneRect(-100,-100,200,200);
    setBackgroundBrush(Qt::yellow);
    pdfView = new QGraphicsPixmapItem();
    this->addItem(pdfView);
    pdfView->show();
    pdfView->setPos(0,0);


    QGraphicsScene *s = this;

    QGraphicsRectItem *r = new QGraphicsRectItem(QRect(-50,-50,100,100));
    this->addRect(QRect(-50,-50,100,100));
}


void PictureScene::onPdfImageReady(const QPixmap &pic)
{
    pdfView->setPixmap(pic);

    QRectF r = itemsBoundingRect();

}
