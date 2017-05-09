
function hover(element){
	//document.getElementsByClassName("img-responsive").style.transition = "all 2s";
	/*document.getElementsByClassName('img-responsive').style.WebkitTransition = 'opacity 1s';
	document.getElementsByClassName('img-responsive').style.MozTransition = 'opacity 1s';*/
	element.setAttribute('src', 'img/2.gif');
	
}
function unhover(element){
	//document.getElementsByClassName('img-responsive').style.WebkitTransition = 'opacity 1s';
	//document.getElementsByClassName('img-responsive').style.MozTransition = 'opacity 1s';
	//document.getElementsByClassName("img-responsive").style.transition = "all 2s";
	element.setAttribute('src', 'img/thumbnail.jpg')
	
}