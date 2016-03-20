/* globals $ */

/* 
 Create a function that takes an id or DOM element and an array of contents
 * if an id is provided, select the element with the specified id
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neither `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function  solve() {
    return function (element, contents) {

        function isString(obj) {
            return typeof obj === 'string' ||  obj instanceof String;
        }

        function isNumber(obj) {
            return typeof obj === 'number' || obj instanceof Number;
        }

        function isHTMLElement(obj) {
            return obj instanceof HTMLElement;
        }

        function validateDOMElement(obj) {
            if (!(isString(obj) || isHTMLElement(obj))) {
                throw new Error('Input parameter is invalid DOM element');
            }
        }

        function validateMissingParameters(param1, param2) {
            if (param1 === undefined || param2 === undefined) {
                throw new Error('Input parameter is missing');
            }
        }

        function validateContent(contents) {
            if (contents.some(function (content) {
                return !isString(content) && !isNumber(content);
            })) {
                throw new Error('One of the contents in the array is not valid');
            }
        }

        var i,
            len,
            selectedElement,
            currentFirstChild,
            divElement,
            documentFragment,
            currentDivElement;

        validateDOMElement(element);
        validateMissingParameters(element, contents);
        if (isString(element)) {
            selectedElement = document.getElementById(element);
        } else {
            selectedElement = element;
        }

        validateContent(contents);

        currentFirstChild = selectedElement.firstChild;
        while (currentFirstChild) {
            selectedElement.removeChild(currentFirstChild);
            currentFirstChild = selectedElement.firstChild;
        }

        divElement = document.createElement('div');
        len = contents.length;
        documentFragment = document.createDocumentFragment();

        for (i = 0; i < len ; i += 1) {
            currentDivElement = divElement.cloneNode(true);
            currentDivElement.innerHTML = contents[i];
            documentFragment.appendChild(currentDivElement);
        }

        selectedElement.appendChild(documentFragment);


    };
};