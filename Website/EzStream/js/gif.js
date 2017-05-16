
function hover(element,link){
	//document.getElementsByClassName("img-responsive").style.transition = "all 2s";
	/*document.getElementsByClassName('img-responsive').style.WebkitTransition = 'opacity 1s';
	document.getElementsByClassName('img-responsive').style.MozTransition = 'opacity 1s';*/
	element.setAttribute('src', link);
	
}
function unhover(element,thumbnail){
	//document.getElementsByClassName('img-responsive').style.WebkitTransition = 'opacity 1s';
	//document.getElementsByClassName('img-responsive').style.MozTransition = 'opacity 1s';
	//document.getElementsByClassName("img-responsive").style.transition = "all 2s";
	element.setAttribute('src', thumbnail);
	
}