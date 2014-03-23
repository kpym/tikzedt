#include "mainwindow.h"
#include "texcompiler.h"
#include "teglobals.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MainWindow w;

    // wire up signals
    QObject::connect(&TexCompiler::Instance, SIGNAL(statusMessage(QString, bool)),
                     &w, SLOT(StatusMessage(QString,bool)) );
    QObject::connect(&TexCompiler::Instance, SIGNAL(compilationComplete(CompilationResult)),
                     &w, SLOT(CompilationComplete(CompilationResult)) );

    w.show();
    w.StatusMessage("Welcome to TikzEdt", false);
    w.StatusMessage("Application directory is "+TEGlobals::Instance.getAppDirectory(), false);
    w.StatusMessage("Settings directory is "+TEGlobals::Instance.getSettingsDirectory(), false);
    return a.exec();
}
