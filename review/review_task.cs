using System;
// using System.linq;
public class Task1 {
 public static void Main(String[] args){
   Random rnd = new Random();
   int n = 10;
   Students[] acs = new Students[n];
   string[] firstNames = {"Wade","Lucy","George","Dan","Melody","Janet","Lauren","Riley","Brian","Liam","Vicky","Molly","Glen","Milton","Claude"};
   string[] lastNames = {"Harris","Thomas","Robinson","Walker","Scott","Nelson","Mitchell","Morgan","Cooper","Howard","Davis","Miller","Martin","Smith","Anderson"};
   for(int i = 0 ; i < n; i ++){
     acs[i].setName(firstNames[i] + " " + lastNames[i]);
     acs[i].setSection(rnd.Next(10));
     acs[i].setGrade(rnd.Next(100));
     Console.WriteLine(rnd.Next(10));
   }

   int avg = 0;
   for(int i = 0 ; i < n ; i ++){
     Console.WriteLine("Hello my name is " + acs[i].getName() + ". I am a student in section " + acs[i].getSection() + " and my final grade is " + acs[i].getGrade() + ".");
     avg += acs[i].getGrade();
   }
   Console.WriteLine("The class average is " + (avg/n) + ".");

 }
}
public class Students{
  private string name;
  private int section;
  private int finalGrade;
  public Students () {}
  public Students (string name, int section, int grade) {
    this.name = name;
    this.section = section;
    this.finalGrade = grade;
  }
  public Students (string name, int section) {
    this.name = name;
    this.section = section;
  }
  public string getName() {
    return this.name;
  }
  public int getSection() {
    return this.section;
  }
  public int getGrade() {
    return this.finalGrade;
  }
  public void setName(string s) {
    this.name = s;
  }
  public void setSection(int i) {
    this.section = i;
  }
  public void setGrade(int i){
    this.finalGrade = i;
  }
  public string gradeType() {
    if(finalGrade > 95){
      return "exceed expectations";
    }else if(finalGrade > 85){
      return "excellent";
    }else if(finalGrade > 70){
      return "very good";
    }else if(finalGrade > 50){
      return "satisfactory";
    }else{
      return "poor";
    }
  }
}
