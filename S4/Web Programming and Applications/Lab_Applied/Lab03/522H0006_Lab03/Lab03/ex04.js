var imageList = document.getElementById('imageList');
var displayedImage = document.querySelector('img');
var imageCount = imageList.options.length;
var currentIndex = 0;

// Function to next the picture
function Next() {
    currentIndex++;

    if (currentIndex >= imageCount) {
        currentIndex = 0;
    }
    
    displayedImage.src = "images/" + imageList.options[currentIndex].value;

    updateCaption();
}

// Function to back to previous picture
function Back() {
    currentIndex--;

    if (currentIndex < 0) {
        currentIndex = 0;
    }
    
    displayedImage.src = "images/" + imageList.options[currentIndex].value;

    updateCaption();
}

// Function to update caption
function updateCaption() {
    var caption = document.querySelector('p');
    caption.textContent = imageList.options[currentIndex].value + " (" + (currentIndex + 1) + "/" + imageCount + ")";
}

var slideshowInterval;

// Function to Start or Stop slide show
function toggleSlideshow() {
    var button = document.querySelectorAll('button')[1];

    if (slideshowInterval) {
        clearInterval(slideshowInterval);
        slideshowInterval = null;
        button.textContent = "Start slideshow";
        
        document.querySelectorAll('button')[0].disabled = false;
        document.querySelectorAll('button')[2].disabled = false;

    } else {
        button.textContent = "Stop slideshow";
        
        document.querySelectorAll('button')[0].disabled = true;
        document.querySelectorAll('button')[2].disabled = true;

        slideshowInterval = setInterval(Next, 1000);
    }
}
