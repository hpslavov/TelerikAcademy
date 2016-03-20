/* Task Description */
/* 
* Create a module for a Telerik Academy course
* 
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
    * 
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * 
  * Create method init
  * 
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
    * 
    * 
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
    * 
    * 
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
    * 
    * 
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
    * 
    * 
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
    * 
    * 
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var ID = 1;


    //checks for at least 1 symbol, starting empty spaces, ending empty spaces.
    function isValidTitle(title) {
        var regxp = /\s{2,}/g;

        if (title.length <= 1 || title[0] === ' ' || title[title.length - 1] === ' ') {
            return false;
        }
        return !regxp.test(title);
    }

    //checks if 1st letter is uppercase and rest letters are lower case
    function isValidName(name) {
        if (name[0] === name[0].toLowerCase()) {
            return false;
        }
        for (var i = 1; i < name.length; i += 1) {
            if (name[i] === name[i].toUpperCase()) {
                return false;
            }
        }
        return true;
    }

    function checkIfStudentExist(students, studentID) {
        return students.some(function (student) {
            return student.id === studentID;
        });
    }

    function validateHomeWorkID(presentations, homeworkID) {
        if (homeworkID < 1 || homeworkID > presentations.length || isNaN(parseInt(homeworkID))) {
            return false;
        }
        return true;
    }
    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];
            ID = 1;

            return this;
        },
        addStudent: function (name) {
            if (name) {
                var names = name.split(' ');
                var firstname,
                    lastname;
                if (names.length !== 2) {
                    throw new Error('student cannot attent with more than 2 names');
                }
                firstname = names[0];
                lastname = names[1];
            }
            if (!isValidName(firstname) || !isValidName(lastname)) {
                throw new Error('First or Last name are not correct');
            }
            this.students.push({
                firstname: firstname,
                lastname: lastname,
                id: ID
            });
            return ID++;
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
           
            if (!checkIfStudentExist(this.students, studentID)) {
                throw new Error('Student ID is not valid');
            }
            if (!validateHomeWorkID(this.presentations, homeworkID)) {
                throw new Error('Homework ID is not valid');
            }
        },
        pushExamResults: function (results) {
            var studentID;
            var score;
            if (!Array.isArray(results)) {
                throw new Error('Input data is not an array');
            }
            for (var i = 0; i < results.length; i += 1) {
                studentID = results[i].studentID;
                score = results[i].score;
                if (!checkIfStudentExist(this.students, studentID)) {
                    throw new Error('Invalid student ID');
                }
                if (this.students[studentID - 1].exam) {
                    throw new Error('Cheating student')
                }
                if (isNaN(parseInt(score))) {
                    throw new Error('Invalid score');
                }
                this.students[studentID - 1].exam = true;
                this.students[studentID - 1].score = score;
            }
        },
        getTopStudents: function () {

        }
    };

    Object.defineProperty(Course, 'title', {
        get: function () {
            return this._title;
        },
        set: function (value) {
            if (!isValidTitle(value)) {
                throw new Error('Invalid course title');
            }
            this._title = value;
        }
    });

    Object.defineProperty(Course, 'presentations', {
        get: function () {
            return this._presentations;
        },
        set: function (value) {
            var i,
                len = value.length;
            if (value && value.length) {

                for (i = 0; i < len; i += 1) {
                    if (!isValidTitle(value[i])) {
                        throw new Error('Presentations titles are not valid in the array');
                    }
                }
                this._presentations = value;
            } else {
                throw new Error('Cannot create a course without presentation');
            }

        }
    });


    return Course;
}


module.exports = solve;
//var test = solve();
//var presentations = ['C#','JavaScript'];
//var courseOne = test.init('C#', presentations);

//courseOne.addStudent('Petur Petrov');
//courseOne.submitHomework(1, 1);
//console.log(courseOne.getAllStudents());
//console.log(courseOne.getTopStudents());