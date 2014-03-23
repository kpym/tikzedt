#ifndef TEXHIGHLIGHTER_H
#define TEXHIGHLIGHTER_H

#include <QSyntaxHighlighter>
#include <QTextDocument>

class TexHighlighter : public QSyntaxHighlighter
{
    Q_OBJECT
public:
    //explicit TexHighlighter(QObject *parent = 0);
    explicit TexHighlighter(QTextDocument *parent = 0);

protected:
    void highlightBlock(const QString &text);

private:
    struct HighlightingRule
    {
        QRegExp pattern;
        QTextCharFormat format;
    };
    QVector<HighlightingRule> highlightingRules;

    QRegExp commentStartExpression;
    QRegExp commentEndExpression;

    QTextCharFormat keywordFormat;
    QTextCharFormat classFormat;
    QTextCharFormat singleLineCommentFormat;
    QTextCharFormat multiLineCommentFormat;
    QTextCharFormat quotationFormat;
    QTextCharFormat functionFormat;


signals:

public slots:

};

#endif // TEXHIGHLIGHTER_H
