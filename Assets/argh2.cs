
using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class StudentDataManager : MonoBehaviour
{
    //Inputfiels for saving student details
    public InputField nameInput;
    public InputField ageInput;
    public InputField studentnumberInput;
    public InputField studentSection;


    //display for Search
    public Text resultText;
    //search inputField
    public InputField searchInput;

    //save Student Data
    public void SaveStudentData()
    {
        string studentName = nameInput.text;
        string Section = studentSection.text;
        int age;
        int studentNumber;
        //check if fields are not empty and parse values
        if (!string.IsNullOrEmpty(studentName) &&
             int.TryParse(ageInput.text, out age) &&
             int.TryParse(studentnumberInput.text, out studentNumber) &&
             !string.IsNullOrEmpty(Section))
        {
            //Save data in PlayerPrefs
            PlayerPrefs.SetInt(studentName + "Age", age);
            PlayerPrefs.SetInt(studentName + "studentNumber", studentNumber);
            PlayerPrefs.SetString(studentName + "Student Section", Section);
            PlayerPrefs.Save();
            Debug.Log("Student Data Saved" + studentName);
        }
        else
        {
            Debug.Log("InvalidInput");
        }


    }
    //Loading Student Data
    public void LoadStudentData()
    {
        string studentName = searchInput.text;
        if (PlayerPrefs.HasKey(studentName + "Age"))
        {
            int age = PlayerPrefs.GetInt(studentName = "Age");
            int studentNumber = PlayerPrefs.GetInt(studentName + "StudentNumber");
            string Section = PlayerPrefs.GetString(studentName + "Student Section");
            resultText.text = $"Name : {studentName}\nAge: {age}\nStudentNumber {studentNumber}\nSection {Section}";
        }
        else
        {
            resultText.text = "Student Not Found";
        }
    }

}