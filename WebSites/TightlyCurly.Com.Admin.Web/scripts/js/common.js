// JavaScript Document

function changeElementClass(elementId, className)
{
	if (typeof(elementId) != "undefined" && typeof(className) != "undefined")
	{
		if (elementId != null && className != null)
		{
			var element = document.getElementById(elementId);
			
			if (typeof(element) != "undefined")
			{
				if (element != null)
				{
					element.className = className;
				}
			}
		}
	}
}

function sleep(milliseconds)
{
	if (typeof(milliseconds) != "undefined")
	{
		if (milliseconds != null) {
			setTimeout(stubFunction(), milliseconds);
		}
	}
}

function displayConfirm(message) {
    if (message) {
        return confirm(message);
    }
}

/*

*/
function stubFunction(){
}