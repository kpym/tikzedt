#ifndef TEGLOBALS_H
#define TEGLOBALS_H

#include <QObject>
#include <QSettings>
#include <QCoreApplication>
#include <QDir>
#include <QFileInfo>

class TEGlobals : public QObject
{
    Q_OBJECT
public:
    explicit TEGlobals(QObject *parent = 0);
    static TEGlobals Instance;

    const QString DefaultTexPreamble = "\\documentclass{article} \n"
                               "%\\def\\pgfsysdriver{pgfsys-tex4ht.def}\n"
                               "\\usepackage{tikz,amsmath, amssymb,bm,color}\n"
                               "\\usepackage[margin=0cm,nohead]{geometry}\n"
                               "\\usepackage[active,tightpage]{preview}\n"
                               "\\usetikzlibrary{shapes,arrows}\n"
                               "% needed for BB\n"
                               "\\usetikzlibrary{calc}\n"
                               "\n"
                               "\\PreviewEnvironment{tikzpicture}\n";
    QString getTexPreamble();
    QString getPrecompiledHeaderPath() {
        return appendPath(getSettingsDirectory(), "pcheaders"); }
    QString getPrecompiledHeaderShortFMTPath() { return getPrecompiledHeaderPath(); }
    QString getPrecompiledHeaderName() { return "pcheaders"; }

    QString getAppDirectory() { return QCoreApplication::applicationDirPath(); }
    QString getSettingsDirectory() {
        return QFileInfo(settings.fileName()).absolutePath();
        //return appendPath(getAppDirectory(), "data");
    }

    QString getPdfLatexPath()
    {
        //return "/usr/texbin/pdflatex";
        return "pdlatex";
    }

    QString getHtLatexPath()
    {
        return "/usr/texbin/htlatex";
    }


    static QString appendPath(const QString& path1, const QString& path2)
    {
        return QDir::cleanPath(path1 + QDir::separator() + path2);
    }
signals:
    void changedTexPreamble(QString);


public slots:
    void setTexPreamble(QString);

protected:
    QSettings settings;

};

#endif // TEGLOBALS_H
