function UnityProgress (dom) {
	this.progress = 0.0;
	this.message = "";
	this.dom = dom;

	var parent = dom.parentNode;

	this.spinner = document.getElementById("spinner");

	this.progressBar = document.getElementById("progressbar");
	this.progressBar.style.display = "none";

	this.messageArea = document.getElementById("message");
	this.messageArea.style.display = "none";

	this.SetProgress = function (progress) {
		this.progress = progress;
		this.progressBar.style.display = "block";
		this.Update();
	}

	this.SetMessage = function (message) {
		this.message = message;
		this.messageArea.style.display = "block";
		this.Update();
	}

	this.Clear = function() {
		this.messageArea.style.display = "none";
		this.progressBar.style.display = "none";
		this.spinner.style.display = "none";
	}

	this.Update = function() {
		this.progressBar.style.width = Math.round(Math.min(this.progress, 1) * 100) + "%";
		this.messageArea.innerText = this.message;
	}

	this.Update();
}