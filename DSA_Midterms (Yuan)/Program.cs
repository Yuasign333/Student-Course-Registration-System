using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DSA_midterms // (Yuan)
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----List Used-----

            List<string> EnrolledStudentNames = new List<string>(); // list to store enrolled student names

            List<string> EnrolledStudentIDs = new List<string>(); // list to store enrolled student IDs

            List<string> EnrolledCourseNames = new List<string>(); // list to store enrolled course names

            List<string> CoursesList = new List<string> { "Ethics", "Math Application in IT", "Programming 2" }; // list to store available courses ( not fixed, can be added or removed by the admin in output)

            // -----Queue Used-----

            Queue<string> WaitlistStudentNames = new Queue<string>(); // queue to store waitlisted student names

            Queue<string> WaitlistStudentIDs = new Queue<string>(); // queue to store waitlisted student IDs

            Queue<string> WaitlistCourseNames = new Queue<string>(); // queue to store waitlisted course names


            // -----Array Used-----

            string[] studentNames = { "Yuan Mendoza", "Eudrick Velasquez", "Ethan Ramos", "Ross Sanchez", "Chris Magbuhos", "Iram Azul", "Luis Cawa", "Justin Fabiculanan", "Ivan Gaspar", "John Gonda"}; // the start of the program will have 10 fixed student ( manually add students in the array code)
            string[] studentNumbers = { "24-0084C", "24-0040C", "24-0097C", "24-0091C", "24-0093C", "24-0041C", "24-0044C", "24-0088C", "24-0077C", "24-0082C"}; // the start of the program will have 10 fixed student IDs ( we can manually add student id in the array code)


            // -----Outside Case Variable Used-----

            string userInput; // variable to store user input

            int maxEnrolled = 4; // you can change the max enrolled students in a course here

            // Note: The variable declaration on cases are inside the case statement. This is for presentation purposes

            // Raw User interface
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.SetCursorPosition(119, 20); // spacing x and y axis
            Console.WriteLine("                       _ _      ");
            Console.WriteLine(" _ __   ___   ___   __| | | ___ ");
            Console.WriteLine("| '_ \\ / _ \\ / _ \\ / _ | |/ _ \\");
            Console.WriteLine("| | | | (_) | (_) | (_| | |  __/");
            Console.WriteLine("|_| |_|/___/ \\___/ \\__,_|_|\\___|");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.SetCursorPosition(85, 25);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("-----PLEASE LOG IN-----");

            bool login = false;

            string UserName = "Admin123";
            string Password = "Noodle2025";

            while (!login) // simple log in interface
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(45, 5);
                Console.Write("-----ADMIN LOGIN PANEL-----");

                Console.ResetColor();

                Console.SetCursorPosition(36, 8);
                Console.Write("  Enter your User Name: ");

                Console.SetCursorPosition(60, 8);
                string userNameInput = Console.ReadLine();

                Console.SetCursorPosition(36, 10);
                Console.Write("  Enter your Password: ");

                Console.SetCursorPosition(59, 10);
                string passwordInput = Console.ReadLine();

                if (userNameInput == UserName && passwordInput == Password)
                {
                    Console.SetCursorPosition(36, 14);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Login successful! Press any key to continue...");
                    Console.ResetColor();
                    Console.ReadKey();
                    login = true;
                }
                else
                {
                    Console.SetCursorPosition(31, 14);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong User Name or Password. Press any key to try again...");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(38, 12);
            Console.WriteLine($" {UserName}, you are now accessing Noodle.");
            Console.ResetColor();
            Console.SetCursorPosition(50, 16);

            Console.Write("  Loading"); 

            for (int i = 0; i < 5; i++) // loading animation
            {
                Console.Write(".");
                Thread.Sleep(400);
            }
            Console.Clear();

            do // loop for the menu
            {
                // Menu
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=====================================");
                Console.WriteLine("     STUDENT COURSE REGISTRATION     ");
                Console.WriteLine("=====================================");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n1. View Available Courses");
                Console.WriteLine("\n2. Enroll Student in a Course");
                Console.WriteLine("\n3. View Courses with Enrolled Students");
                Console.WriteLine("\n4. Drop a Student Course");
                Console.WriteLine("\n5. Check Student's Waitlist Status");
                Console.WriteLine("\n6. Search Student by ID");
                Console.WriteLine("\n7. Manage Courses (Add/Remove)");
                Console.WriteLine("\n8. View All Students in the System");
                Console.WriteLine("\n9. Exit");
                Console.Write("\nEnter your choice: ");
                Console.ResetColor();

                userInput = Console.ReadLine(); // get user input
                Console.Clear();


                switch (userInput) // switch case for the menu
                {

                    case "1": // View Available Courses

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n========= Available Courses =========\n");
                        Console.ResetColor();

                        for (int i = 0; i < CoursesList.Count; i++) // loop through the available courses (list with courses already)
                        {
                            string course = CoursesList[i]; // list passed to course variable

                            int enrolledCount = 0; // variable to count enrolled students

                            // Count enrolled students for this course (list)

                            for (int j = 0; j < EnrolledCourseNames.Count; j++)
                            {
                                if (EnrolledCourseNames[j] == course) // check if the course is equal to the course in the list
                                {
                                    enrolledCount++; // increment the count
                                }
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"\n{i + 1}. {course} "); // display the course name

                            if (enrolledCount >= maxEnrolled) // check if the course is full
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("(Full)");
                            }
                            else // if not still full
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("(Not Full)");
                            }

                            Console.ResetColor();
                        }

                   
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        Console.ResetColor();

                        break;

                    case "2": // Enroll Student in a Course

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\n========= Enrollment =============\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\nEnter Student Name: ");

                        string studentName = Console.ReadLine().ToUpper(); // get student name and convert to upper case

                        Console.Write("\nEnter Student ID: ");

                       string studentID = Console.ReadLine().ToUpper(); // get student ID and convert to upper case

                        bool isValid = false; // bool flag for idiot-proffing in the enrollment process

                        // Check if the student exists in the valid student (array)

                        for (int i = 0; i < studentNumbers.Length; i++) 
                        {
                            if (studentNames[i].ToUpper() == studentName && studentNumbers[i].ToUpper() == studentID) // check if user input on student and id equal to the array of students and IDs
                            {
                                isValid = true;
                                break; // exits the loop if found
                            }
                        }

                        if (!isValid)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid student name or ID.");
                            Console.ResetColor();
                            Console.ReadKey();
                            break; // exit the case 
                        }



                        Console.WriteLine("\nSelect a course:");
                        Console.WriteLine();

                        for (int i = 0; i < CoursesList.Count; i++) // loop through the available courses (list)
                        {
                            Console.WriteLine((i + 1) + ". " + CoursesList[i]); // display the course name
                            Console.WriteLine();
                        }

                        Console.Write("\nCourse number: ");

                        int courseNumber; // variable to store course number

                        if (!int.TryParse(Console.ReadLine(), out courseNumber) || courseNumber < 1 || courseNumber > CoursesList.Count) // check if the input is a valid number and within the range of available courses
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid course selection.");
                            Console.ResetColor();
                            Console.ReadKey();
                            break; // exit the case
                        }

                        string selectedCourse = CoursesList[courseNumber - 1]; // implicit conversion of the course number to the course name

                        bool alreadyExists = false; // bool flag to check if the student is already enrolled or waitlisted

                        // Check if student is already enrolled in the selected course (list)

                        for (int i = 0; i < EnrolledStudentIDs.Count; i++) // loop through the enrolled student IDs
                        {
                            if (EnrolledStudentIDs[i] == studentID && EnrolledCourseNames[i] == selectedCourse) // check if the student ID and course name match
                            {
                                alreadyExists = true; // already enrolled
                                break; 
                            }
                        }

                        // Check if current student is already waitlisted for the selected course (list)
                

                        int waitlistCount = WaitlistStudentIDs.Count; // get the count of waitlisted students (ID based)

                        for (int i = 0; i < waitlistCount; i++) // loop through the waitlisted students
                        {
                            // pull out the first student ID, course name, and student name from the queue and check if it matches the current student ID and course name

                            string queuedID = WaitlistStudentIDs.Dequeue(); // dequeue the first student ID in the waitlist

                            string queuedCourse = WaitlistCourseNames.Dequeue(); // dequeue the first course name in the waitlist

                            string queuedName = WaitlistStudentNames.Dequeue(); // dequeue the first student name in the waitlist


                            if (queuedID == studentID && queuedCourse == selectedCourse) // check if the student ID and course name match
                            {
                                alreadyExists = true; // already waitlisted
                            }

                          // Enqueue back to preserve order ( put the student ID, course name, and student name back to the queue)
                            
                                WaitlistStudentIDs.Enqueue(queuedID); // enqueue the student ID back to the queue

                                WaitlistCourseNames.Enqueue(queuedCourse); // enqueue the course name back to the queue

                                WaitlistStudentNames.Enqueue(queuedName); // enqueue the student name back to the queue
                         

                            if (alreadyExists)  //  exits the for loop 
                            {
                                break; // goes to exits the case
                            }
                        }

                        if (alreadyExists) // exits the case
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nThis student is already enrolled or waitlisted for this course.");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }

                        // ADDITIONAL: Check if ANY student is waitlisted for the course (list)

                        // If admin tries to add a student even if there are waitlisted students, we block the enrollment to ensure fairness to students on the waitlist must be enrolled first (check Case 5 to process the waitlist).


                        bool courseHasWaitlisted = false; // bool flag to check if the course has waitlisted students

                        int originalWaitlistCount = WaitlistCourseNames.Count; // get the count of waitlisted students (course based)

                        for (int i = 0; i < originalWaitlistCount; i++)
                        {
                            string queuedID = WaitlistStudentIDs.Dequeue(); // dequeue the first student ID in the waitlist

                            string queuedCourse = WaitlistCourseNames.Dequeue();// dequeue the first course name in the waitlist

                            string queuedName = WaitlistStudentNames.Dequeue(); // dequeue the first student name in the waitlist


                            if (queuedCourse == selectedCourse)// Check if any student is waitlisted for this course
                            {
                                courseHasWaitlisted = true; // course has waitlisted students
                            }

                            // Enqueue back to preserve order

                            WaitlistStudentIDs.Enqueue(queuedID); // enqueue the student ID back to the queue

                            WaitlistCourseNames.Enqueue(queuedCourse); // enqueue the course name back to the queue

                            WaitlistStudentNames.Enqueue(queuedName); // enqueue the student name back to the queue
                        }

                        // If the course is not full and has no waitlist

                        int count = 0; // variable to count the number of students enrolled in the selected course

                        for (int i = 0; i < EnrolledCourseNames.Count; i++)
                        {
                            if (EnrolledCourseNames[i] == selectedCourse) // check if the course name matches the selected course
                            {
                                count++; // increment the count
                            }
                        }

                        if (count < maxEnrolled) // check if the course is not full
                        {
                            if (courseHasWaitlisted) // if admin tries to add a student even if there are waitlisted student
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nCannot enroll directly. There are waitlisted students for this course.");

                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("\nPlease process them via Menu Number 5.");
                            }
                            else      // Enroll the student if there is space and no waitlist
                            {
                           

                                EnrolledStudentNames.Add(studentName); // add the student name to the enrolled list

                                EnrolledStudentIDs.Add(studentID); // add the student ID to the enrolled list

                                EnrolledCourseNames.Add(selectedCourse); // add the course name to the enrolled list

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nEnrollment successful.");
                            }
                        }
                        else // if the course is full
                        {
                            // If the course is full, add the student to the waitlist

                            WaitlistStudentNames.Enqueue(studentName); // enqueue the student name to the waitlist

                            WaitlistStudentIDs.Enqueue(studentID); // enqueue the student ID to the waitlist

                            WaitlistCourseNames.Enqueue(selectedCourse); // enqueue the course name to the waitlist

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nCourse full. Added to waitlist.");
                        }

                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "3": // View Courses with Enrolled Students

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n========= View Courses with Enrolled Students ============\n");
                        Console.ResetColor();

                        foreach (string course in CoursesList) // loop through available course (list)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\nCourse: " + course);
                            Console.ResetColor();

                            int enrolledCount = 0; // variable to count enrolled students

                            // Count how many students are enrolled in the current course (list)
                            for (int i = 0; i < EnrolledCourseNames.Count; i++)
                            {
                                if (EnrolledCourseNames[i] == course) // check if the course name mateches
                                {
                                    enrolledCount++; // increment the count
                                }
                            }

                            // Display the list of enrolled students

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("\nEnrolled Students: ");

                            for (int i = 0; i < EnrolledCourseNames.Count; i++) // loop through the enrolled students
                            {
                                if (EnrolledCourseNames[i] == course) // check if the course name matches
                                {
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("-" + EnrolledStudentNames[i].ToUpper() + " (" + EnrolledStudentIDs[i] + ")"); // display the student name and ID (list)
                                    Console.ResetColor();
                                }
                            }

                            // Display how many available slots are left

                            int availableSlots = maxEnrolled - enrolledCount; // calculate available slots


                            if (availableSlots == 0) // if no slots left
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nNo available slots.");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("\n------------------------------------");
                                Console.WriteLine();
                                Console.ResetColor();
                            }
                            else // if there are available slots
                            {

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nAvailable slots: " + availableSlots);
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.WriteLine("\n------------------------------------");
                                Console.WriteLine();
                                Console.ResetColor();
                            }
                           
                        }

                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "4": // Drop a Student Course

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\n========= Drop a Student Course ============\n");
                        Console.ResetColor();

                        // Show available courses
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\nSelect a course to drop from:");

                        Console.WriteLine();

                        for (int i = 0; i < CoursesList.Count; i++) // loop through the available courses (list)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine($"{i + 1}. {CoursesList[i]}"); // display the course name
                            Console.WriteLine();
                            Console.ResetColor();
                        }

                        Console.Write("\nEnter course number: ");

                        int courseIndex; // variable to store course index

                        if (!int.TryParse(Console.ReadLine(), out courseIndex) || courseIndex < 1 || courseIndex > CoursesList.Count) // check if the input is a valid number and within the range of available courses

                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid course selection.");
                            Console.ResetColor();
                            Console.ReadKey();
                            break;
                        }

                        string courseToDrop = CoursesList[courseIndex - 1]; // implicit conversion of the course number to the course name

                        Console.Write("\nEnter Student ID to drop: ");

                        string dropStudentID = Console.ReadLine().Trim().ToUpper(); // get student ID and convert to upper case

                  

                        bool found = false; // bool flag to check if the student is found

                        for (int i = 0; i < EnrolledStudentIDs.Count; i++) // loop through the enrolled students (List)
                        {
                            studentName = EnrolledStudentNames[i]; // get student name before removing

                            if (EnrolledStudentIDs[i] == dropStudentID && EnrolledCourseNames[i] == courseToDrop) // check if the student ID and course name match
                            {
                                // Drop the student from the course (index based removal)

                                EnrolledStudentNames.RemoveAt(i); // remove the student name from the enrolled list

                                EnrolledStudentIDs.RemoveAt(i); // remove the student ID from the enrolled list

                                EnrolledCourseNames.RemoveAt(i); // remove the course name from the enrolled list

                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($"\nStudent '{studentName}' is dropped successfully.");
                                Console.ResetColor();

                                found = true; // student found

                                // student drop, waitlist students will be promoted to the course

                                waitlistCount = WaitlistStudentIDs.Count; // get the count of waitlisted students

                                for (int j = 0; j < waitlistCount; j++) // loop through the waitlisted students
                                {
                                    string waitingName = WaitlistStudentNames.Dequeue(); // dequeue the first student name in the waitlist

                                    string waitingID = WaitlistStudentIDs.Dequeue(); // dequeue the first student ID in the waitlist

                                    string waitingCourse = WaitlistCourseNames.Dequeue(); // dequeue the first course name in the waitlist

                                    if (waitingCourse == courseToDrop && !found) // check if the course name matches and the student is not found in the enrolled list
                                    {
                                        
                                        EnrolledStudentNames.Add(waitingName); // add the student name to the enrolled list

                                        EnrolledStudentIDs.Add(waitingID); // add the student ID to the enrolled list

                                        EnrolledCourseNames.Add(waitingCourse); // add the course name to the enrolled list

                                        Console.WriteLine("\nPromoted from waitlist: " + waitingName); // display the student name

                                        found = true; // student found
                                    }
                                    else // if the course name 
                                    {
                                        // Enqueue back to preserve order
                                        // put the student ID, course name, and student name back to the queue

                                        WaitlistStudentNames.Enqueue(waitingName); // enqueue the student name back to the queue

                                        WaitlistStudentIDs.Enqueue(waitingID); // enqueue the student ID back to the queue

                                        WaitlistCourseNames.Enqueue(waitingCourse); // enqueue the course name back to the queue
                                    }
                                }
                                break;
                            }
                        }

                        if (!found) // if student not found
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nStudent not found in the selected course.");
                            Console.ResetColor();
                        }


                  
                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "5": // Check Student's Waitlist Status

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\n========= Waitlist Status ============\n");
                        Console.ResetColor();

                        if (WaitlistStudentIDs.Count == 0) // check if the waitlist is empty
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The waitlist is currently empty.");
                            Console.ResetColor();
                        }
                        else // if waitlist not empty
                        {


                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Select a course to view its waitlist:\n");

                            for (int i = 0; i < CoursesList.Count; i++)  // Show available courses
                            {
                                Console.WriteLine($"\n{i + 1}. {CoursesList[i]}");
                            }

                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("\nEnter course number: ");
                            Console.ResetColor();

                            int selectedCourseIndex; // variable to store selected course index

                            if (!int.TryParse(Console.ReadLine(), out selectedCourseIndex) || selectedCourseIndex < 1 || selectedCourseIndex > CoursesList.Count) // check if the input is a valid number and within the range of available courses

                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nInvalid course selection.");
                                Console.ResetColor();
                                Console.WriteLine("\nPress any key to return to the menu...");
                                Console.ReadKey();
                                break;
                            }

                            selectedCourse = CoursesList[selectedCourseIndex - 1]; // implicit conversion of the course number to the course name

                            bool hasWaitlist = false; // bool flag to check if there are waitlisted students

                            count = 1; // variable to count the number of waitlisted students

                            // Filter and display only those in waitlist for selected course

                            int waitlistSize = WaitlistStudentIDs.Count; // get the count of waitlisted students

                            for (int i = 0; i < waitlistSize; i++) // loop through the waitlisted students
                            {
                                string queuedName = WaitlistStudentNames.Dequeue(); // dequeue the first student name in the waitlist

                                string queuedID = WaitlistStudentIDs.Dequeue(); // dequeue the first student ID in the waitlist

                                string queuedCourse = WaitlistCourseNames.Dequeue(); // dequeue the first course name in the waitlist

                                if (queuedCourse == selectedCourse) // check if the course name matches the selected course
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"\n{count}. {queuedName.ToUpper()} - {queuedID} - {queuedCourse}"); // display the student name, ID, and course name
                                    Console.ResetColor();

                                    count++; // increment the count

                                    hasWaitlist = true; // student is waitlisted
                                }

                                // Enqueue back to preserve data
                                WaitlistStudentNames.Enqueue(queuedName); // enqueue the student name back to the queue

                                WaitlistStudentIDs.Enqueue(queuedID); // enqueue the student ID back to the queue

                                WaitlistCourseNames.Enqueue(queuedCourse); // enqueue the course name back to the queue
                            }

                            if (!hasWaitlist) //if no waitlisted studenta
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\nNo students are waitlisted for {selectedCourse}.");
                                Console.ResetColor();
                            }
                            // After viewing the waitlist, check if someone can be enrolled

                            if (hasWaitlist)
                            {
                                int waitlistCountForCourse = WaitlistStudentIDs.Count;

                                for (int i = 0; i < waitlistCountForCourse; i++)
                                {
                                    string name = WaitlistStudentNames.Dequeue();
                                    string id = WaitlistStudentIDs.Dequeue();
                                    string course = WaitlistCourseNames.Dequeue();

                                    // Count how many students are already enrolled in this specific course
                                    int enrolledInThisCourse = 0;
                                    for (int j = 0; j < EnrolledCourseNames.Count; j++)
                                    {
                                        if (EnrolledCourseNames[j] == selectedCourse)
                                        {
                                            enrolledInThisCourse++;
                                        }
                                    }

                                    // Check if the current waitlisted student can be enrolled
                                    if (course == selectedCourse && enrolledInThisCourse < maxEnrolled)
                                    {
                                        EnrolledStudentNames.Add(name);
                                        EnrolledStudentIDs.Add(id);
                                        EnrolledCourseNames.Add(course);

                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine($"\n{name.ToUpper()} has been auto-enrolled in {course} from the waitlist.");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        // Requeue student if they cannot be enrolled yet
                                        WaitlistStudentNames.Enqueue(name);
                                        WaitlistStudentIDs.Enqueue(id);
                                        WaitlistCourseNames.Enqueue(course);
                                    }
                                }

                            }
                        }

                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;


                    case "6": // Search Student by ID

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n========= Search Student by ID ========\n");
                        Console.ResetColor();

                        Console.Write("Enter Student ID to search: ");

                       string searchStudentID = Console.ReadLine().ToUpper(); // user input for student ID and convert to upper case

                        found = false; // bool flag to check if the student is found

                        for (int i = 0; i < studentNumbers.Length; i++) // loop through the fixed student IDs (array)
                        {
                            if (studentNumbers[i].ToUpper() == searchStudentID) // check if the student ID matches
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nFound: " + studentNames[i] + " - " + studentNumbers[i]); // display the student name and ID

                                bool enrolled = false; // bool flag to check if the student is enrolled

                                string enrolledCourses = ""; // variable to store enrolled courses

                                for (int j = 0; j < EnrolledStudentIDs.Count; j++) // loop through the enrolled students (lists)
                                {
                                    if (EnrolledStudentIDs[j].ToUpper() == searchStudentID) // check if the student ID matches
                                    {
                                        enrolledCourses += " - " + EnrolledCourseNames[j]; // add the course name to the enrolled courses

                                        enrolled = true;
                                    }
                                }

                                if (enrolled) // if the student is enrolled
                                {
                                    Console.WriteLine("\nStatus 1: Enrolled in" + enrolledCourses);
                                }

                                else // if not enrolled
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nStatus 1: Not enrolled in any course.");
                                }

                                // Check if waitlisted (always, regardless of enrollment)

                                bool waitlisted = false; // bool flag to check if the student is
                                                         
                                string waitlistedCourses = ""; // variable to store waitlisted courses

                                waitlistCount = WaitlistStudentIDs.Count; // get the count of waitlisted students

                                for (int j = 0; j < waitlistCount; j++) // loop through the waitlisted students
                                {
                                    string name = WaitlistStudentNames.Dequeue(); // dequeue the first student name in the waitlist

                                    string id = WaitlistStudentIDs.Dequeue(); // dequeue the first student ID in the waitlist

                                    string course = WaitlistCourseNames.Dequeue(); // dequeue the first course name in the waitlist

                                    if (id.ToUpper() == searchStudentID) // check if the student ID matches
                                    {
                                        waitlistedCourses += " - " + course; // add the course name to the waitlisted courses

                                        waitlisted = true; // student is waitlisted
                                    }

                                    // Preserve queue state

                                    WaitlistStudentNames.Enqueue(name); // enqueue the student name back to the queue

                                    WaitlistStudentIDs.Enqueue(id); // enqueue the student ID back to the queue

                                    WaitlistCourseNames.Enqueue(course); // enqueue the course name back to the queue
                                }

                                if (waitlisted) // if the student is waitlisted
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nStatus 2: Waitlisted for" + waitlistedCourses);
                                }
                                else // if not waitlisted
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nStatus 2: Not waitlisted for any course.");
                                }

                                found = true; // student found
                                break;
                            }
                        }


                        if (!found) // if not found
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nStudent ID not found.");
                        }

                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;


                    case "7": // Manage Courses

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n========= Manage Courses ============\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1.Add a Course");
                        Console.WriteLine("\n2.Remove a Course");
                        Console.Write("\nEnter your choice: ");
                        Console.ResetColor();

                        string manageChoice = Console.ReadLine(); // get user input

                        if (manageChoice == "1") // if user inputs 1
                        {
                            Console.Write("\nEnter course name to add: ");

                            string newCourse = Console.ReadLine(); // user input for new course

                            CoursesList.Add(newCourse); // add the new course to the list

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("\nCourse '" + newCourse.Trim() + "' added successfully."); // display success message
                        }

                        else if (manageChoice == "2") // if user inputs 2
                        {
                            Console.WriteLine("\nAvailable Courses to Remove:");
                            Console.WriteLine();

                            for (int i = 0; i < CoursesList.Count; i++) // loop through the available courses (list)
                            {
                               Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine( (i + 1) + ". " + CoursesList[i]); // display the course name
                                Console.WriteLine();
                                Console.ResetColor();
                            }
                            Console.Write("\nEnter course number to remove: ");

                            int removeCourseNumber; // variable to store course number

                            if (int.TryParse(Console.ReadLine(), out removeCourseNumber) && removeCourseNumber >= 1 && removeCourseNumber <= CoursesList.Count) // check if the input is a valid number and within the range of available courses
                            
                            {
                                string courseToRemove = CoursesList[removeCourseNumber - 1]; // implicit conversion of the course number to the course name

                                CoursesList.RemoveAt(removeCourseNumber - 1); // remove the course from the list (index-based)

                                Console.ForegroundColor = ConsoleColor.Green;

                                Console.WriteLine("\nCourse '" + courseToRemove + "' removed successfully."); // display success message
                            }
                            else // if invalid inout
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nInvalid course selection.");
                            }
                        }
                        else // if invalid input
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid choice.");
                        }
                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;

                    case "8": // View Students
                       
                            Console.WriteLine("\n========= View Students ============\n");
                            Console.ResetColor();

                            // Display all students
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Registered Students in the System:");
                            Console.ResetColor();

                            // Display fixed students (array(
                            for (int i = 0; i < studentNames.Length; i++)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine($"\n{i + 1}. {studentNames[i]} ({studentNumbers[i]})"); // display the student name and ID
                        }
                        Console.ReadKey();

                         
                        break;

                    case "9": // Exit 

                        break; // Exit the program

                    default: // idiot-poof on menu options

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid choice.");
                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to return to the menu...");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();

            } 
            while (userInput != "9"); // Exit condition for the whole program
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nThank you for using NOODLE!"); // end program
                Console.ResetColor();
                Console.ReadKey();
            }
            Console.WriteLine();
        }
    }
}
