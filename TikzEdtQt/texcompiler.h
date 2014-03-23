#ifndef TEXCOMPILER_H
#define TEXCOMPILER_H

#include <QObject>
#include <QProcess>
#include <QtCore>


enum CompileJobType { JOB_TYPE_PREVIEW, JOB_TYPE_HEADERS, JOB_TYPE_INPLACE };

struct CompileJob
{
    CompileJob() {}
    CompileJob(QString tcode, QString tfile) : code(tcode), file(tfile) {}

    CompileJobType job_type;


    int document_id;
    int job_id;
    QString code;
    QString file;

};

struct CompilationResult
{

    QString outFile;

    QString TexOutput;

    CompileJob job;
};

class TexCompiler : public QObject
{
    Q_OBJECT
public:
    explicit TexCompiler(QObject *parent = 0);

signals:
    void compilationComplete(CompilationResult res);
    void processRunningChanged(bool running);
    void statusMessage(QString text, bool isError);

public slots:
    void compile( CompileJob job);
    void compileHeaders();

protected slots:
    void processFinished(int exitCode, QProcess::ExitStatus exitStatus);
    void processStarted();
    void processError(QProcess::ProcessError error);
    void processReadyStd();
    void processReadyErr();

protected:
    QProcess process;
    CompileJob currentJob;
    CompileJob pendingJob;
    CompilationResult currentResult;
    int jobId = 0;

    void startPendingJob();



public:
    static TexCompiler Instance;
    static CompileJob PrecompileHeadersJob;
};

#endif // TEXCOMPILER_H
