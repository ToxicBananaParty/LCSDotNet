using OpenTK.Graphics;
using SunshineConsole;
using OpenTK.Input;

namespace LCSDotNet.Data
{
    public static class TextExtensions
    {
        public static void Write(this ConsoleWindow console, int row, int col, string text)
        {
            console.Write(row, col, text, Color4.White);
        }

        public static void Write(this ConsoleWindow console, int row, string text)
        {
	        int column = (Program.width - text.Length) / 2;
	        console.Write(row, column, text, Color4.White);
        }

        public static void Write(this ConsoleWindow console, int row, string text, Color4 color)
        {
	        int column = (Program.width - text.Length) / 2;
	        console.Write(row, column, text, color);
        }

        public static string GetInput(this ConsoleWindow console, int row, int column)
        {
	        string input = "";
	        while (console.WindowUpdate()) {
		        if (console.KeyPressed) {
			        Key pressed = console.GetKey();
			        if (pressed == Key.Enter)
				        return input;

			        if (!char.IsLetter((char) pressed))
				        continue;

			        input += pressed.ToString().ToLower();
			        
			        console.Write(row, column, pressed.ToString().ToLower());
			        column++;
		        }
	        }

	        return null;
        }
		
		public static string GetInput(this ConsoleWindow console, bool allowEnter = true) 
		{
			string input = "";
			while(console.WindowUpdate()) {
				if(console.KeyPressed) {
					Key pressed = console.GetKey();
					
					if(allowEnter) {
						if(!char.IsLetter((char)pressed) && pressed != Key.Enter)
							continue;
						return pressed.ToString().ToLower();
					}
					else {
						if(!char.IsLetter((char)pressed))
							continue;
						return pressed.ToString().ToLower();
					}
				}
			}
			
			return null;
		}

		public static void Clear(this ConsoleWindow console)
		{
			console.HoldUpdates();
			for (int i = 0; i < Program.width; i++) {
				for (int j = 0; j < Program.height; j++) {
					console.Write(j, i, " ", Color4.Black);
				}
			}
			console.ResumeUpdates();
		}
    }
}