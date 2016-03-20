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
	
	
	//validations from task - Modules and Patterns
	
	
	
	//-------------------------------Helper functions from prototypal inheritance
	
	//a valid type is any non-empty string that contains only Latin letters and digits
	 function isValidType(type) {
            if (typeof type !== 'string') {
                throw new Error('Invalid type');
            }
            return /^[A-Z0-9]+$/i.test(type);
        }

		
		//valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
        function isValidAttributeName(name) {
            if (typeof name !== 'string') {
                throw new Error('invalid attribute name');
            }
            return /^[A-Z0-9\-]+$/i.test(name);
        }

        function sortAttributes(attributes) {

            var attributesString = '';
            var keys = [];

            for (var key in attributes) {
                keys.push(key);
            }


            keys.sort();
            var currentKey;
            var len = keys.length;
            for (var i = 0 ; i < len ; i += 1) {
                currentKey = keys[i];
                attributesString += ' ' + currentKey + '="' + attributes[currentKey] + '"';
            }

            return attributesString;
        }
