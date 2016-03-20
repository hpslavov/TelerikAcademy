/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
      
      if (typeof selector !== 'string') {
          throw new Error('Selector is not string');
      }

      var $selectedElement = $(selector);
      var $allBtns = $selectedElement.find('.button');

      if (!$selectedElement.length) {
          throw new Error('Selector is not a valid jquery object');
      }

      for (var i = 0; i < $allBtns.length; i++) {
          $currentBtn = $($allBtns[i]);
          $currentBtn.text('hide');

          $currentBtn.on('click', onBtnClick);
      }

      function onBtnClick() {

          var $this = $(this);

          var $nextCntn = $this.nextAll('.content').first();
          $nextBtn = $nextCntn.nextAll('.button').first();

          if ($nextBtn.length && $nextCntn.length) {
              
              if ($nextCntn.css('display') === 'none') {
                  $nextCntn.css('display') = '';
                  $this.text('hide');
              } else {
                  $nextCntn.css('display') = 'none';
                  $this.text('show');
              }
          }

      }


  };
};

module.exports = solve;