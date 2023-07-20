# students-and-subjects
## **Overview**

‘Students and Subjects’ is a web-based project developed for a tech test as part of the assessment. The primary goal of this project is to create a web application that allows users to view a list of students, create new student accounts, and browse university courses. Please note that this version of the project is not connected to a database, and the validation is performed on the client-side.

## **Features**

Each feature corresponds to Tasks 1 to 4 that were set in the practical assessment. 

1. **View designs for a relational database**: Had this project been connected to a database, these designs show you how it would occur. 
2. **View a list of students**: Users can access a page, via the navigation bar, that displays a list of students
3. **Create a new student account**: Users can create a new student account by providing necessary information which includes; title, name, email, date of birth and up to 2 subjects. The application performs client-side validation.
4. **Browse university courses**: Users can view a list of university courses. However, due to a known issue, clicking on a course link currently does not redirect to a detailed course page.

## **Technologies Used**

The following technologies were utilised to build ‘Students and Subjects’:

- **ASP.NET MVC**: Used to structure the application and handle server-side logic.
- **C#**: The primary programming language for the backend development.
- **JavaScript**: Used for client-side interactions and form validation.
- **HTML**: Used for creating the structure of web pages.
- **CSS**: Utilised for styling and the presentation of the web pages.

## **Getting Started**

To get started, you will need to have the following prerequisites, the minimum versions needed are shown alongside.

### **Prerequisites**

- **ASP.NET Core SDK 7.0**
- **Visual Studio v17.6.1**
- **Bootstrap v5.3**

### **Installation**

As this version of the project doesn't connect to a database, you can fork and clone the repository and run it locally by following these steps:

1. Make sure you have the necessary prerequisites installed.
2. Clone the repository using Git:

```
git clone https://github.com/rotimijoseph/students-and-subjects.git
```

1. Open the project in Visual Studio.
2. Build and run the project using the appropriate debugging settings.

## **Known Issues**

Clicking on the links of individual university courses does not lead to a page with more details about which partner university the course can be studied at. This issue will be addressed if future updates were to occur.

## **Future Improvements**

While this version of the project fulfills most of the requirements for the tech test, there are several areas where improvements can be made:

1. **Database integration**: Connect the application to a database to store and manage students and course data more effectively, this would be carried out using either PostgreSQL or SQL server.
2. **Server-side validation**: Implement server-side validation to enhance data integrity and security.
3. **Course details page**: Create a detailed page for each university course showing the name of partner universities that the course can be studied at, accessible by clicking on the name of the course.
4. **User Authentication**: Implement user authentication and authorisation to restrict access to certain parts of the application.
5. **Improved UI/UX**: Enhance the user interface and user experience to make the application more intuitive and visually appealing.
6. **Testing**: The use of MSTest to carry out tests on the MVC components

## **Contributions**

Contributions to this project are not accepted at this moment as it is solely intended for the tech test. However, you are welcome to fork the repository and make modifications for your personal use.
