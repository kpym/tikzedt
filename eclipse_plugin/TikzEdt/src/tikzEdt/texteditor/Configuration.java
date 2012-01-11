package tikzEdt.texteditor;

import org.eclipse.jface.text.IDocument;
import org.eclipse.jface.text.ITextHover;
import org.eclipse.jface.text.contentassist.ContentAssistant;
import org.eclipse.jface.text.contentassist.IContentAssistProcessor;
import org.eclipse.jface.text.contentassist.IContentAssistant;
import org.eclipse.jface.text.presentation.IPresentationReconciler;
import org.eclipse.jface.text.presentation.PresentationReconciler;
import org.eclipse.jface.text.rules.DefaultDamagerRepairer;
import org.eclipse.jface.text.source.ISourceViewer;
import org.eclipse.jface.text.source.SourceViewerConfiguration;
import org.eclipse.ui.texteditor.ContentAssistAction;

public class Configuration extends SourceViewerConfiguration {
	@Override
	public IPresentationReconciler getPresentationReconciler(ISourceViewer sourceViewer)
	{
		PresentationReconciler pr = new PresentationReconciler();
		DefaultDamagerRepairer dr = new DefaultDamagerRepairer(new Scanner());
		pr.setRepairer(dr, IDocument.DEFAULT_CONTENT_TYPE);
		pr.setDamager(dr, IDocument.DEFAULT_CONTENT_TYPE);
		return pr;
		
	}
	@Override
	public IContentAssistant getContentAssistant(ISourceViewer sv)
	{
		ContentAssistant ca = new ContentAssistant();
		IContentAssistProcessor cap = new CompletionProcessor();
		ca.setContentAssistProcessor(cap, IDocument.DEFAULT_CONTENT_TYPE);
		ca.setInformationControlCreator(getInformationControlCreator(sv));
		return ca;
	}
	@Override
	public ITextHover getTextHover(ISourceViewer sv, String contentType)
	{
		return new TextHover();
	}
}
