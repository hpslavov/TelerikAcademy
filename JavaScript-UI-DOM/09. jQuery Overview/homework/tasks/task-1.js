/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {

      if (!count) {
          throw new Error();
      }

      if (!(typeof count === 'number')) {
          throw new Error();
      }

      if (count < 1) {
          throw new Error();
      }

      if (!selector) {
          throw new Error();
      }

      var $liElement = $('<li>');
      var $ulElement = $('<ul>');
      var $selectedElement;

      $selectedElement = $(selector);

      if ($selectedElement.length) {
          $liElement.addClass('list-item');
          $ulElement.addClass('item-list');

          for (var i = 0; i < count; i++) {
              var $newLi = $liElement.clone();

              $newLi.html('List item #' + i);
              $ulElement.append($newLi);
          }

          $selectedElement.append($ulElement);
      }


  };
};

module.exports = solve;