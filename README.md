# Metin2-SendInput
Sending Input to Metin2 with C# (Simulate key press, works on everything... I guess..)

Hello, i didnt find anyone who made C# script where you can simulate keyboard press. 
I made little bit of research at pinvoke.net (take me about 3-4 days) and created this dll.
Whole guide is on youtube so you can have better understanding how to use this dll. (no need virus total)
Its in alpha so take it ez. Ofc there will be some bugs. https://www.youtube.com/watch?v=NgUEXTk-a7g&t=19s

How to use it : 

EButton.Button btn = new EButton.Button();

short space = (short)EButton.Button.BT7.SPACE;

short F4 = (short)EButton.Button.BT7.F4;

void ExampleFunction()
{

//You have 2 seconds to activate specific window

Thread.Sleep(2000);

//It will press space 

buttonbtn.PressKey(space)

}

