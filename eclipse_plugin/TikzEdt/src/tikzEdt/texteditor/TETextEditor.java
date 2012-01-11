package tikzEdt.texteditor;

import org.eclipse.ui.editors.text.TextEditor;

public class TETextEditor extends TextEditor {
	public TETextEditor()
	{
		super();
		setSourceViewerConfiguration(new Configuration());
	}

}
