#creates the zip files to upload to google code for the linux and mac versions of TikzEdt

version=0_2_1
lin32="TikzEdt_"$version"_linux_x86.tar.gz"
lin64="TikzEdt_"$version"_linux_amd64.tar.gz"
mac="TikzEdt_"$version"_osx.tar.gz"

p=`pwd`

mkdir temp

cd ../bin/Release

cp -r Editor TikzEdtWForms.exe Antlr3.Runtime.dll ICSharpCode.SharpZipLib.dll StringTemplate.dll ICSharpCode.TextEditor.dll TEApplicationLogic.dll Antlr3.Utility.dll TESharedComponents.dll tikzedt antlr.runtime.dll TikzParser.dll FindReplaceNoWPF.dll SnippetThumbs.zip license.rtf license.txt mudraw_pdfdraw_license.txt PDFLibNet.dll $p"/temp"

#tar -zcvf $p"/"$lin32 Editor TikzEdtWForms.exe Antlr3.Runtime.dll ICSharpCode.SharpZipLib.dll StringTemplate.dll ICSharpCode.TextEditor.dll TEApplicationLogic.dll Antlr3.Utility.dll TESharedComponents.dll tikzedt antlr.runtime.dll TikzParser.dll FindReplaceNoWPF.dll SnippetThumbs.zip license.rtf license.txt mudraw_pdfdraw_license.txt

cd $p

cp -r temp/* linuxx86files
cp -r temp/* linuxamd64files
cp -r temp/* macfiles

cp -r macfiles/* TikzEdt.app/Contents/MacOS

cd linuxx86files
tar -zcvf ../$lin32 *
cd ../linuxamd64files
tar -zcvf ../$lin64 *
cd ../macfiles
tar -zcvf ../$mac *

cd $p

tar -zcvf TikzEdt.tar.gz TikzEdt.app

#cp $lin32 $lin64
#cp $lin32 $mac

#tar -rzvf $lin32 linuxx86files/pdfdraw
