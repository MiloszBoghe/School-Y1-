// selecteer instantievariabelen van een klasse en doe CTRL+RE --> SST (Satan Secret Technique)
// goede manier programma afsluiten:
 Environment.Exit(0);
//InvoerDemo VOOR DE SOLUTION FOLDER: string sourcepath = @"..\..\";
string sourcepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
string myfile = System.IO.Path.Combine(sourcepath, "myfile.txt");
StreamReader inputStream = new StreamReader(myFile, System.Text.Encoding.Default);
try{
string line = inputStream.ReadLine();
while(line!=  null)
{
    fileTextBox.AppendText(line);
    fileTextBox.AppendText(Environment.NewLine);
    line = inputStream.ReadLine();
}
}
catch (FileNotFoundException)
{
    MessageBox.Show("Bestand niet gevonden!");
}
finally
{
    inputStream.Close();
}

//UitvoerDemo
            string destination = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string file = System.IO.Path.Combine(destination, "adres.txt");
            StreamWriter s = File.CreateText(file);
            s.WriteLine("Joachim Veulemans");
            s.WriteLine("Straat huisnummer");
            s.WriteLine("3270 Scherpenheuvel");
            s.Close();

//MenuDemo
    <DockPanel>
        <Menu DockPanel.Dock="Top">
            <MenuItem Header="_File">
                <MenuItem Header="_Open" />
                <MenuItem Header="_Save" />
                <Separator />
                <MenuItem Header="E_xit"/>
            </MenuItem>
            <MenuItem Header="_Help">
                <MenuItem Header="_About"/>
            </MenuItem>

        </Menu>
        <Grid DockPanel.Dock="Bottom">

        </Grid>
    </DockPanel>

//Sorteren      naamgeving => naam.eigenschap ------- sorteert dus volgens deze eigenschap. 
//Dit werkt alleen voor objecten die eigenschappen hebben die met elkaar vergeleken kunnen worden. bv:(int, timespan, ..)
naam = naam.OrderBy(o => o.OrderNaam).ToList(); // naam is een List
naam = naam.OrderByDescending(o => o.OrderNaam).ToList(); // Descending


//Als de lijst niet uit objecten bestaat maar bv gewoon uit int, bv:
private List<int> getallen = new List<int>();
getallen.Add(1000);
getallen.Add(500);
getallen.Add(16516);
getallen.Sort();


//String omdraaien (Reverse)
public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

//Dictionary
private Dictionary <string, Object> naam = new Dictionary <string, Object>();

//Klasse Directory
GetFiles(path);
GetDirectories(path);

//FolderBrowserDialog add reference Windows.Forms
folderBrowser.ShowDialog();
allFiles = Directory.GetFiles(folderBrowser.SelectedPath, "*.txt");

//StreamWriter
StreamWriter outputStream = File.CreateText("NaamFile.txt");
outputStream.WriteLine("Tekst");
outputStream.Close();

//Slider
<Slider TickPlacement="BottomRight" Name="ValueCardsSlider"  TickFrequency="1" IsSnapToTickEnabled="True" Minimum="1"  Maximum="13"  HorizontalAlignment="Left" Margin="168,155,0,0" VerticalAlignment="Top" RenderTransformOrigin="0.151,1.709" Width="200"/>


// 
public void DisableEvents()
{
	removeButton.Click -= RemoveButton_Click;
	addButton.Click -= AddButton_Click;
}

private void EnableEvents()
{
	removeButton.Click += RemoveButton_Click;
	addButton.Click += AddButton_Click;
}


//Afbeelding
BitmapImage bi = new BitmapImage();
bi.BeginInit();
bi.UriSource = uri;
bi.EndInit();
Image image = new Image()
{
Width = 0,
Height = 0,
Margin = new Thickness(0, 0, 0, 0),
Source = bi
};
CardCanvas.Children.Add(image);

//OpenFile Dialog
OpenFileDialog openFileDialog = new OpenFileDialog();
string startdir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
openFileDialog.InitialDirectory = startdir;
openFileDialog.Filter = "Image Files | *.BMP;" + "*.JPG; *.GIF|Zll files(*.*) | *.*";

if(openFileDialog.ShowDialog() == true){ 
    System.Windows.MessageBox.Show(openFileDialog.FileName);
}
//Als bovenstaande niet werkt : 
if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK){
	 System.Windows.MessageBox.Show(openFileDialog.FileName);
}



//OpenFileInCurrentDirectory
OpenFileDialog fileDialog = new OpenFileDialog();
            string path = Environment.CurrentDirectory;

            for (int i = 0; i < 2; i++)
            {
                path = path.Remove(path.LastIndexOf('\\'));
            }

            fileDialog.InitialDirectory = path;
            fileDialog.Filter = "Text Files|*.txt";
            if (fileDialog.ShowDialog() == true) //User clicks open 
			                             //System.Windows.Forms.DialogResult.OK als true niet werkt.
            {
                path = fileDialog.FileName;
                StreamReader inputStream = null;

                try
                {
					inputStream = File.OpenText(path);
					string line = inputStream.ReadLine();
                    while(line!=  null)
                    {
                        fileTextBox.AppendText(line);
                        fileTextBox.AppendText(Environment.NewLine);
                        line = inputStream.ReadLine();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Error: not enough lines in file!");
                }
                finally
                {
                    inputStream?.Close();
                }
            }


