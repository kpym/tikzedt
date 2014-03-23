#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "texcompiler.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::StatusMessage(QString text, bool isError)
{
    if (!isError)
        ui->txtStatus->appendPlainText(text);
    else
        ui->txtStatus->appendHtml("<p style='color:#ff0000;'>"+text+"</p>");
}

void MainWindow::CompilationComplete(CompilationResult res)
{
    ui->txtTexOutput->document()->setPlainText(res.TexOutput);
}

void MainWindow::on_action_Re_Compile_Headers_triggered()
{
    //TexCompiler::Instance.compile(TexCompiler::PrecompileHeadersJob);
    TexCompiler::Instance.compileHeaders();
}

void MainWindow::on_actionCompile_triggered()
{
    CompileJob job;
    job.code = ui->txtCode->document()->toPlainText();
    TexCompiler::Instance.compile(job);
}
