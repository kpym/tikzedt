#-------------------------------------------------
#
# Project created by QtCreator 2014-03-15T14:20:46
#
#-------------------------------------------------

QT       += core gui xml svg

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

qtHaveModule(opengl): QT += opengl

TARGET = TikzEdtQt
TEMPLATE = app


SOURCES += main.cpp\
        mainwindow.cpp \
    mycodeeditor.cpp \
    texhighlighter.cpp \
    svgview.cpp \
    texcompiler.cpp \
    teglobals.cpp \
    picturescene.cpp \
    pdfimageprovider.cpp

HEADERS  += mainwindow.h \
    mycodeeditor.h \
    texhighlighter.h \
    svgview.h \
    texcompiler.h \
    teglobals.h \
    picturescene.h \
    pdfimageprovider.h

FORMS    += mainwindow.ui

RESOURCES += \
    TEResources.qrc

OTHER_FILES += \
    make_headers.sh

INCLUDEPATH  += /usr/include/poppler/qt5
LIBS         += -L/usr/lib -lpoppler-qt5
