#include "teglobals.h"

TEGlobals::TEGlobals(QObject *parent) :
    QObject(parent), settings(QString("config.ini"), QSettings::IniFormat)
{

}

 TEGlobals TEGlobals::Instance;

void TEGlobals::setTexPreamble(QString val)
{
    settings.setValue("TexPreamble", val);
}
QString TEGlobals::getTexPreamble()
{
    QString val = settings.value("TexPreamble", DefaultTexPreamble).toString();
    return val;
}
