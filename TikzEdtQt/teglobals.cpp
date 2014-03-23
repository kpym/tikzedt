#include "teglobals.h"

TEGlobals::TEGlobals(QObject *parent) :
    QObject(parent), settings(QString("config.ini"), QSettings::IniFormat)
{
    // copy header makefile
    QString shfile(appendPath(getSettingsDirectory(), "make_headers.sh"));
  //  if (!QFile::exists(shfile))
   //     QFile::copy(appendPath(getAppDirectory(), "make_headers.sh"),
     //           shfile);
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
