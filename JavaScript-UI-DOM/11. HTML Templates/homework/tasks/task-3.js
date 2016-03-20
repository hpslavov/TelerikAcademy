function solve(){
  return function(){
    $.fn.listview = function(data){
        var $this = $(this);
        var id = '#' + $this.attr('data-template');
    };
  };
}

module.exports = solve;