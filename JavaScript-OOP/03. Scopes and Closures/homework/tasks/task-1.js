/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
			* 
		*	Add validation everywhere, where possible
			*	//Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	//Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function validateTitleName(book) {

            if (book.title.length < 2) {
                throw new Error('Title is too short');
            } else if (book.title.length > 100) {
                throw new Error('Title is too long');
            }
        }

        function validateAuthorName(book) {
            var emptyStr = '';
            if (book.author === emptyStr) {
                throw new Error('Author name is invalid');
            }
        }

        function validateISBN(book) {
            var isbnToStr = book.isbn.toString();
            if (isbnToStr.length !== 10 && isbnToStr.length !==13) {
                throw new Error('ISBN is not valid');
            }
        }


        function isBookTitleUnique(book) {
            var i,
                len = books.length;
            for (i = 0 ; i < len ; i += 1) {
                if (book.title === books[i].title) {
                    throw new Error('Title is not unique');
                }
            }
        }

        function isISBNUnique(book) {
            var i,
            len = books.length;
            for (i = 0 ; i < len ; i += 1) {
                if (book.isbn === books[i].isbn) {
                    throw new Error('ISBN is not unique');
                }
            }
        }

        function listBooks(obj) {
            var result = [];
            if (obj && obj.author) {
                result = books.filter(function (book) {
                    return book.author === obj.author;
                });
            } else if (obj && obj.category) {
                result = books.filter(function (book) {
                    return book.category === obj.category;
                });
            } else {
                result = books;
            }
            result = result.sort(function (firstBook, secondBook) {
                return firstBook.ID - secondBook.ID;
            });
            return result;
        }

        function addBook(book) {
            validateTitleName(book);
            validateAuthorName(book);
            isBookTitleUnique(book);
            isISBNUnique(book);
            validateISBN(book);
            book.ID = books.length + 1;
            books.push(book);
            if (categories.indexOf(book.category) === -1) {
                book.category.ID += categories.length + 1;
                categories.push(book.category);
            }

            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;