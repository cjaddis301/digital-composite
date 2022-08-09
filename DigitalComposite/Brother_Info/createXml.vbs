Option Explicit
       
	Dim filesys			: Set filesys = CreateObject("Scripting.FileSystemObject") 
	Dim wshShell		: Set wshShell = CreateObject("WScript.Shell")       
	Dim sourceDirectory	: sourceDirectory = wshShell.CurrentDirectory & "\" 
	Dim folder			: Set folder = filesys.GetFolder(sourceDirectory)
	Dim doubleQuotes 	: doubleQuotes = Chr(34)
	Const BytesToKb = 1024 	: Const BytesToMb = 1048576	: Const BytesToGB = 1073741824

	createXml(folder)

Sub createXml(Directory)
    Dim objFolder, objFile, summaryInfo
    
    Dim broName : broName = InputBox ("Enter in the name of the brother" , "Enter Name")
    Dim broBond : broBond = InputBox ("Enter in the bond number of the brother" , "Enter Bond")
    Dim broYear : broYear = InputBox ("Enter in the year of the brother" , "Enter Year")
    Dim broMajor : broMajor = InputBox ("Enter in the major of the brother" , "Enter Major")
  
    Dim objTextFile : Set objTextFile = filesys.CreateTextFile(sourceDirectory & broBond & ".xml", True)           

	' Create Name & tags
    objTextFile.WriteLine "<name>"
    objTextFile.WriteLine "Name: "  & broName 
    objTextFile.WriteLine "</name>"

	' Create Bond & tags
    objTextFile.WriteLine "<bond>"
    objTextFile.WriteLine "Bond: "  & broBond               
    objTextFile.WriteLine "</bond>"

	' Create Year & tags
    objTextFile.WriteLine "<year>"
    objTextFile.WriteLine "Year: "  & broYear 
    objTextFile.WriteLine "</year>"

	' Create Major & tags
    objTextFile.WriteLine "<major>"
    objTextFile.WriteLine "Major: " & broMajor                
    objTextFile.WriteLine "</major>"
	
	
    objTextFile.close    
   
    wshRun sourceDirectory & broBond & ".xml"
    
End Sub

'***************************  Run A File ***************************' 
'Runs a program in a new process.
    
Private Sub wshRun(ByVal File)     
     wshShell.Run "notepad " & doubleQuotes & File & doubleQuotes, 1, false        
End Sub