#include "texcompiler.h"
#include "teglobals.h"

TexCompiler::TexCompiler(QObject *parent) :
    QObject(parent)
{
    QObject::connect(&process, SIGNAL(finished(int, QProcess::ExitStatus)),
                     this, SLOT(processFinished(int, QProcess::ExitStatus) ) );
    QObject::connect(&process, SIGNAL(started()),
                             this, SLOT(processStarted() ) );
    QObject::connect(&process, SIGNAL(readyReadStandardError()),
                             this, SLOT(processReadyErr() ) );
    QObject::connect(&process, SIGNAL(readyReadStandardOutput()),
                             this, SLOT(processReadyStd() ) );
    QObject::connect(&process, SIGNAL(error(QProcess::ProcessError )),
                             this, SLOT(processError(QProcess::ProcessError ) ) );

}

 TexCompiler TexCompiler::Instance(0);
 CompileJob TexCompiler::PrecompileHeadersJob("", "PRECOMPILE_HEADERS");

void TexCompiler::processError(QProcess::ProcessError error)
{

    emit statusMessage("Error on running Tex: "+QString::number(error), true);
}

void TexCompiler::processReadyErr()
{

    //emit statusMessage(process.readAllStandardError(), true);
}
void TexCompiler::processReadyStd()
{

    //emit statusMessage(process.readAllStandardError(), false);
}

void TexCompiler::processFinished(int exitCode, QProcess::ExitStatus exitStatus)
{
    emit statusMessage("Process finished "+QString::number(exitCode), false);
    if (exitCode == 0 && exitStatus == QProcess::NormalExit)
    {
        QString output( process.readAllStandardOutput() );
        currentResult.TexOutput = output;
        emit compilationComplete(currentResult);
    }
    else
    {
        QString output( process.readAllStandardOutput() );
        currentResult.TexOutput = output;
        emit compilationComplete(currentResult);
    }
    emit processRunningChanged(false);
}

void TexCompiler::processStarted()
{
    emit statusMessage("Process started", false);

}

void TexCompiler::compile(CompileJob job)
{
    emit statusMessage("Compile job received", false);

    pendingJob = job;
    pendingJob.job_id = ++jobId;
    startPendingJob();

}

void TexCompiler::compileHeaders()
{

    QString pchPath = TEGlobals::Instance.getPrecompiledHeaderPath()+".tex";
    //process.setWorkingDirectory(TEGlobals::Instance.getSettingsDirectory());
    //QProcessEnvironment env = QProcessEnvironment::systemEnvironment();
    //env.insert("PATH", env.value("PATH") + ":/usr/texbin");
    //process.setProcessEnvironment(env);
    QFile file(pchPath);
    if (file.open(QIODevice::ReadWrite))
    {
        emit statusMessage("Generating precompiled headers...", false);
        QTextStream stream(&file);
        stream << TEGlobals::Instance.getTexPreamble() << endl;
        file.close();

        //emit processRunningChanged(true);

        //bname=\"$JOBNAME$\" \"&pdflatex $FILENAME$\\dump\" "; } set { }  }

        //string pchArgs = CompilerSettings.Instance.PrecompiledHeaderCompileCommand;
        //texProcess.StartInfo.Arguments = pchArgs.Replace("$JOBNAME$", job.name).Replace("$FILENAME$", System.IO.Path.GetFileName(job.path));

        QProcess::startDetached("/bin/bash",QStringList() << "make_headers.sh", TEGlobals::Instance.getSettingsDirectory());
        //QProcess::startDetached("/bin/bash");
        //QProcess::startDetached("make_headers.sh",QStringList(), TEGlobals::Instance.getSettingsDirectory());
    }
    else
    {
        emit statusMessage("Error: cannot write to precompiled headers file...", true);

    }
}

void TexCompiler::startPendingJob()
{
    if (pendingJob.job_id != currentJob.job_id
            && process.state() == QProcess::NotRunning)
    {
        currentJob = pendingJob;
        currentResult.job = currentJob;

        // Precompile headers, or normal job?
        if (currentJob.file == PrecompileHeadersJob.file)
        {
            emit statusMessage("Generating precompiled headers..", false);
            QString pchPath = TEGlobals::Instance.getPrecompiledHeaderPath()+".tex";
            QString jobName = TEGlobals::Instance.getPrecompiledHeaderName();
            process.setWorkingDirectory(TEGlobals::Instance.getSettingsDirectory());
            QProcessEnvironment env = QProcessEnvironment::systemEnvironment();
            env.insert("PATH", env.value("PATH") + ":/usr/texbin");
            process.setProcessEnvironment(env);
            QFile file(pchPath);
            if (file.open(QIODevice::ReadWrite))
            {
                QTextStream stream(&file);
                stream << TEGlobals::Instance.getTexPreamble() << endl;
                file.close();

                emit processRunningChanged(true);

                //bname=\"$JOBNAME$\" \"&pdflatex $FILENAME$\\dump\" "; } set { }  }

                //string pchArgs = CompilerSettings.Instance.PrecompiledHeaderCompileCommand;
                //texProcess.StartInfo.Arguments = pchArgs.Replace("$JOBNAME$", job.name).Replace("$FILENAME$", System.IO.Path.GetFileName(job.path));

                QStringList args;
                args << "-ini"
                     <<"-jobname=\""+ jobName +"\""
                     << "&/usr/texbin/pdflatex "+pchPath+"\\dump";


                //process.start(TEGlobals::Instance.getPdfLatexPath(), args);
                process.start("sh", QStringList() <<
                              TEGlobals::appendPath(
                            TEGlobals::Instance.getSettingsDirectory(),
                                  "make_headers.sh") );
                //QProcess::startDetached(TEGlobals::Instance.getPdfLatexPath(), args);
                emit statusMessage("Running pdflatex "+args.join(" "), false);
            }
            else
            {
                emit statusMessage("Error: Cannot open precompiled header file "+pchPath+" for writing.", true);

            }

        }
        else
        {
            // save code to temp file
            QString tempPath(TEGlobals::appendPath( QDir::tempPath(),(QString)"tetemp.tex"));

            currentResult.outFile = TEGlobals::appendPath( QDir::tempPath(),(QString)"tetemp"+currentJob.document_id+".svg");

            QProcessEnvironment env = QProcessEnvironment::systemEnvironment();
            env.insert("PATH", env.value("PATH") + ":/usr/texbin");
            process.setProcessEnvironment(env);
            process.setWorkingDirectory(QDir::tempPath());

            QFile file(tempPath);
            if (file.open(QIODevice::ReadWrite))
            {
                QTextStream stream(&file);
                //s.WriteLine("%& " + Helper.GetPrecompiledHeaderShortFilePath() );
                //                            s.WriteLine("\\begin{document}");
                stream << "%&"
                       << TEGlobals::Instance.getPrecompiledHeaderShortFMTPath()
                       << endl
                       << "\\begin{document}" << endl
                       << currentJob.code << endl
                       << "\\end{document}";
                file.close();

                emit processRunningChanged(true);
                QStringList args;
                args << tempPath;
                process.start(TEGlobals::Instance.getPdfLatexPath(), args);
                emit statusMessage("Running pdflatex "+args.join(" "), false);
            }
            else
            {
                emit statusMessage("Error: Cannot open file "+tempPath+" for writing.", true);
            }
        }
    }
}
