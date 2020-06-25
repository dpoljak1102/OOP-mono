import React from 'react';


class Footer extends React.Component {
    render() {
      return(
        <footer class='page-footer font-small pt-4'>
            <div class='col-2 text-center mx-auto'>
                <h5>BookProject</h5>
                <div class='footer-copyright text-center'>
                    Copyright &copy; 2020
                </div>
                <button type='button' class='btn btn-primary m-3'>Contact us</button>
            </div>
        </footer>
    );
    }
  }
export default Footer;