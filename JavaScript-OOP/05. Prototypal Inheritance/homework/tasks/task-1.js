/* Task Description */
/* Example
var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');
var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)
var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');
div.content = 'Hello, world!';
var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');
var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);
console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/



function solve() {

    var domElement = (function () {

        function isValidType(type) {
            if (typeof type !== 'string') {
                throw new Error('Invalid type');
            }
            return /^[A-Z0-9]+$/i.test(type);
        }

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



        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.attributes = [];
                this.children = [];
                this.parent;
                return this;
            },
            appendChild: function (child) {
                this.children.push(child);
                if (typeof child === 'object') {
                    child.parent = this;
                }
                return this;
            },
            addAttribute: function (name, value) {

                if (!isValidAttributeName(name)) {
                    throw new Error('Invalid attribute name');
                }
                this.attributes[name] = value;

                return this;

            },
            removeAttribute: function (attribute) {
                if (!this.attributes[attribute]) {
                    throw new Error('Attribute does not exist');
                }
                delete this.attributes[attribute];
                return this;
            },
            get innerHTML() {
                var innerHtml = '<' + this.type;
                var attributesStr = sortAttributes(this.attributes);
                innerHtml += attributesStr + '>';

                var child;
                for (var i = 0; i < this.children.length; i += 1) {
                    child = this.children[i];
                    if (typeof child === 'string') {
                        innerHtml += child;
                    } else {
                        innerHtml += child.innerHTML;
                    }
                }

                innerHtml += this.content;
                innerHtml += '</' + this.type + '>';

                return innerHtml;
            }
        };
        Object.defineProperty(domElement, 'type', {
            get: function () {
                return this._type;
            },
            set: function (value) {
                if (!isValidType(value)) {
                    throw new Error('Invalid type');
                }
                this._type = value;
            }
        });
        Object.defineProperty(domElement, 'content', {
            get: function () {
                if (this.children.length) {
                    return '';
                }
                return this._content;
            },
            set: function (value) {
                
                this._content = value;
            }
        });
        Object.defineProperty(domElement, 'children', {
            get: function () {
                return this._children;
            },
            set: function (value) {
                this._children = value;
            }
        });
        Object.defineProperty(domElement, 'parent', {
            get: function () {
                return this._parent;
            },
            set: function (value) {
                this._parent = value;
            }
        });
        Object.defineProperty(domElement, 'attributes', {
            get: function () {
                return this._attributes;
            },
            set: function (value) {
                this._attributes = value;
            }
        });

        return domElement;
    }());
    return domElement;
}

module.exports = solve;


//var meta = Object.create(domElement)
//	.init('meta')
//	.addAttribute('charset', 'utf-8');
//var head = Object.create(domElement)
//	.init('head')
//	.appendChild(meta)
//var div = Object.create(domElement)
//	.init('div')
//	.addAttribute('style', 'font-size: 42px');
//div.content = 'Hello, world!';
//var body = Object.create(domElement)
//	.init('body')
//	.appendChild(div)
//	.addAttribute('id', 'cuki')
//	.addAttribute('bgcolor', '#012345');
//var root = Object.create(domElement)
//	.init('html')
//	.appendChild(head)
//	.appendChild(body);
//console.log(root.innerHTML);
