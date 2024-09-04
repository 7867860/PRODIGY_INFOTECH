window.addEventListener('scroll', function() {
    const header = document.querySelector('header');
    const body = document.querySelector('body');
    const scrollPos = window.scrollY;
  
    if (scrollPos > 200 & scrollPos<800) {
      header.style.backgroundColor = '#555';
      body.style.backgroundColor = '#FFF';
    } else if (scrollPos > 800) {
      header.style.backgroundColor = '#000000';
      body.style.backgroundColor = 'grey';
    } else {
      header.style.backgroundColor = '#333';
      body.style.backgroundColor = '#333';
    }
  });
  
