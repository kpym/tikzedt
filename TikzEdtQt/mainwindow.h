#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "texcompiler.h"

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT


public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

public slots:
    void StatusMessage(QString text, bool isError);
    void CompilationComplete(CompilationResult res);

private slots:
    void on_action_Re_Compile_Headers_triggered();

    void on_actionCompile_triggered();

private:
    Ui::MainWindow *ui;
};

#endif // MAINWINDOW_H
