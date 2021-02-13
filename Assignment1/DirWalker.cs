


using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;
using System.Diagnostics;
public class DirWalker
{
    public static StreamWriter output;
    public static StreamWriter log;

    public static int countInvalid;
    public static int countValid;
    
    
    public static void Main(String[] args)
    {
        String strPath;

        countInvalid=0;
        countValid=0;
        try
        {

        
        Console.WriteLine("Enter DIRECTORY NAME(if exists in current directory)    or   DIRECTORY PATH:");
        strPath = Console.ReadLine();

        output = new StreamWriter("Output/output.csv");
        pf("First Name,Last Name,Street Number,Street,City,Province,Postal Code,Country,Phone Number,email Address,date");
        log = new StreamWriter("logs/logs.txt");

        var calculator = new System.Diagnostics.Stopwatch();

        //start
        calculator.Start();
        traverse(strPath,"");
        //stop
        calculator.Stop();
        pl("\nEXECUTION TIME  ==>  "+calculator.ElapsedMilliseconds+"  milliseconds\n");
        pl("\nVALID ROWS  ==>  " + countValid);
        pl("\nINVALID ROWS  ==>  " + countInvalid);


        output.Close();
        log.Close();     
        }
        catch (FileNotFoundException)
            {
                pl("The file or directory cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                pl("The file or directory cannot be found.");
            }
            catch (DriveNotFoundException)
            {
                pl("The drive specified in 'path' is invalid.");
            }
            catch (PathTooLongException)
            {
                pl("'path' exceeds the maxium supported path length.");
            }
            catch (UnauthorizedAccessException)
            {
                pl("You do not have permission to create this file.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                pl("There is a sharing violation.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                pl("The file already exists.");
            }
            catch (IOException e)
            {
                pl($"An exception occurred:\nError code: " + e.ToString());
            } 
    }
    
    public static void traverse(String path, String space)
        {

            String[] directories = null;
            String[] files = null;
            int i;
            
        try
        {

        
            directories = Directory.GetDirectories(path);
            files = Directory.GetFiles(path);

            
            pl(space + "DIR:  " + Path.GetFullPath(path));
            for(i=0; i<files.Length; i++)
            {
                if(File.Exists(files[i]))
                {
                    
                    pl(space + "\t\tFILE:  " + Path.GetFileName(files[i]));
                    findAbnormalities(files[i], space+"\t\t       \t");
                }

            }
            
            pl("\n\n\n\n");
            
            

            if (directories == null) return;





            for(i=0; i<directories.Length; i++)
            {
                if (Directory.Exists(directories[i]))
                {
                    traverse(directories[i], space+"\t");
                    
                }
            }
            }
            catch (FileNotFoundException)
            {
                pl("The file or directory cannot be found.");
            }
            catch (DirectoryNotFoundException)
            {
                pl("The file or directory cannot be found.");
            }
            catch (DriveNotFoundException)
            {
                pl("The drive specified in 'path' is invalid.");
            }
            catch (PathTooLongException)
            {
                pl("'path' exceeds the maxium supported path length.");
            }
            catch (UnauthorizedAccessException)
            {
                pl("You do not have permission to create this file.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32)
            {
                pl("There is a sharing violation.");
            }
            catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80)
            {
                pl("The file already exists.");
            }
            catch (IOException e)
            {
                pl($"An exception occurred:\nError code: " + e.ToString());
            }
            
            
        }
        public static void pf(String str) //print in a file
        {

            try
            {
                output.WriteLine(str);
            }
            catch(Exception e)
            {
                pl(e.ToString());
            }

        }
        public static void pl(String str) //print in a log
        {


            try
            {

            
                log.WriteLine(str);

            }
            catch(Exception e)
            {
                pl(e.ToString());
            }

        }

        public static void findAbnormalities(String str, String space)
        {

            //str is the path of the file
            int i, r=0;
            String row;
            bool invalidRow, temp;

        String dateVal="";
        try
        {
            //Date 
            String[] values = str.Split('/');
            dateVal= values[1]+"-"+values[2]+"-"+values[3];
            //End of Date
        }
        catch(IndexOutOfRangeException e)
        {
            pl(space + "{EXCEPTION CAUGHT:  " + e.ToString() + "}");
        }
        catch(Exception e)
        {
            pl(space + "{EXCEPTION CAUGHT:  " + e.ToString() + "}");
        }
            

            try 
            { 
                TextFieldParser parser = new TextFieldParser(str);
                
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");
                    parser.HasFieldsEnclosedInQuotes = true;
                        while (!parser.EndOfData)
                        {
                            row="";
                            invalidRow=false;
                            
                            string[] fields = parser.ReadFields();
                            if(r>0) //Header is not needed
                            {
                                for(i=0; i<fields.Length; i++)
                                {
                                    
                                    temp= isInvalid(fields[i],r, i,space);
                                    if(invalidRow==false && temp == true)
                                    {
                                        invalidRow = temp;
                                    }
                                    
                                    if(i==0)
                                    {
                                        row = row + fields[i];
                                    }
                                    else 
                                    {
                                        row = row + "," + fields[i];
                                    }
                                    
                                }
                            }
                            if(!invalidRow)
                            {
                                countValid++;
                                if(r>0)//Header is not needed
                                pf(row + "," + dateVal);
                            }
                            else
                            {
                                countInvalid++;
                            }
                            
                            r++;
                        }
                
                parser.Close();
            }   
            catch(MalformedLineException e)
            {
                pl(e.ToString());
            }
            catch(IOException ioe)
            {
                    pl(ioe.StackTrace);
            }

        }
        public static bool isInvalid(String str, int row, int col, String space)
        {
            bool invalidValue=false;
            String msg="";
                Regex re;


        try
        {

        
                if(str.Equals(""))
                {
                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Empty Value]";
                    invalidValue=true;

                }
                else
                {
                        switch (col)
                        {       
                            case 0:
                                re= new Regex("(^[a-zA-Z]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'First Name']";
                                }
                                break;
                            case 1:
                                re= new Regex("(^[a-zA-Z]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Last Name']";
                                }
                                break;
                            case 2:
                                re= new Regex("(^[0-9]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Street Number']";
                                }
                                break;
                            case 3:
                                re= new Regex("(^[0-9a-zA-Z\\s\\.]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Street']";
                                }
                                break;
                            case 4:
                                re= new Regex("(^[a-zA-Z\\s\\.\\-\\']+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'City']";
                                }
                                break;
                            case 5:
                                re= new Regex("(^[a-zA-Z\\s]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Province']";
                                }
                                break;
                            case 6:
                                re= new Regex("(^[\\s]*[a-zA-Z0-9]{3}\\s[a-zA-Z0-9]{3}[\\s]*$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Postal Code']";
                                }
                                break;
                            case 7:
                                re= new Regex("(^[a-zA-Z\\s\\.]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Country']";
                                }
                                break;
                            case 8:
                                re= new Regex("(^[0-9]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'Phone Number']";
                                }
                                break;
                            case 9:
                                re= new Regex("(^[a-zA-Z_]+[a-zA-Z0-9_\\.]+@[a-zA-Z0-9_]+\\.[a-zA-Z]+$)");
                                if(!re.IsMatch(str))
                                {
                                    invalidValue=true;
                                    msg= "[row "+row+", col "+(col+1)+":\t"+str + " Does not match column 'email Address']";
                                }
                                break;
                        }
                }
        }
        catch (IOException e) 
        {
         pl("IOException :"+e.ToString());
         pl(e.Message);
        }
        catch (RegexMatchTimeoutException e) 
        {
         pl("The operation timed out after {0:N0} milliseconds:  "+e.MatchTimeout.TotalMilliseconds);
        }
                
                if(invalidValue) pl(space+msg);
                return invalidValue;
        }


}



/*
REFEENCES:

https://social.msdn.microsoft.com/Forums/vstudio/en-US/cef083b7-b7c4-4a98-b519-9960db4ad7d1/c-using-an-csv-file?forum=netfxbcl

https://github.com/DanielPenny/MCDA5510_Assignments/

https://docs.microsoft.com/en-us/dotnet/

https://www.geeksforgeeks.org/what-is-regular-expression-in-c-sharp/

https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split

https://docs.microsoft.com/en-us/dotnet/standard/base-types/best-practices



*/