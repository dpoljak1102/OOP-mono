import React from 'react';


class Navbar extends React.Component {
    render() {
      return(
        <nav class=" py-4 navbar navbar-dark navbar-expand-lg bg-dark fixed-top container-fluid">
        <div class="container">
            <a href="#home" class="navbar-brand">BookProject</a>
            <i class="fas fa-user"></i>
            <button class="navbar-toggler"
                type="button"
                data-toggle="collapse"
                data-target="#navbarCollapse"
                aria-controls="navbarCollapse"
                aria-expanded="false"
                aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarCollapse">
                <div class="navbar-nav ml-auto">
                    <a href="#home" class="nav-item nav-link">Home</a>
                    <a href="#books" class="nav-item nav-link">Books</a>
                    <a href="#publishers" class="nav-item nav-link">Publishers</a>
                    <a href="#authors" class="nav-item nav-link">Meet the autors</a>
                </div>
            </div>
        </div>
        </nav>
  );
    }
  }
export default Navbar;