import React from 'react';


class HomeSection extends React.Component {
    render() {
      return(
        <section class="py-5 px-7 bg-dark">
        <div class="primary-overlay text-secondary">
            <div class="container">
                <div class="row">
                    <div class="col-sm-12 col-lg-12 text-center">
                        <h2 class="display-2 mt-5 pt-5">
                            So many books, so little time...
                        </h2>
                        <p class="lead text-danger">
                            Frank Zappa
                        </p>
                    </div>
                </div>
            </div>
        </div>
        </section>
  );
    }
  }
export default HomeSection;