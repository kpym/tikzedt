#ifndef PICTURESCENE_H
#define PICTURESCENE_H

#include <QGraphicsScene>
#include <QGraphicsPixmapItem>

class PictureScene : public QGraphicsScene
{
    Q_OBJECT
public:
    explicit PictureScene(QObject *parent = 0);

signals:

public slots:
    void onPdfImageReady(const QPixmap &pic);

protected:
    QGraphicsPixmapItem *pdfView;
};

#endif // PICTURESCENE_H
