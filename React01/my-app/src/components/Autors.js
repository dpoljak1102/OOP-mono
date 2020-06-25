import React from 'react';


class Autors extends React.Component {
    render() {
      return(
        <section class=" py-5 text-center bg-light">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="info-header w-50 mx-auto">
                        <h1 class="text-silver">
                            Meet the authors
                        </h1>
                    </div>
                </div>
            </div>
            <div class="row py-3">

                <div class="col-md-6 col-lg-3">
                    <div class="card  ">
                        <div class="card-body">
                            <h3>William Shakespeare</h3>
                            <p class="text-muted">Writer</p>
                            <p>Lorem ipsum dolor sit amet consectetur.</p> 
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-3">
                    <div class="card  ">
                        <div class="card-body">
                            <h3>Georges Simenon</h3>
                            <p class="text-muted">Writer</p>
                            <p>Lorem ipsum dolor sit amet consectetur.</p> 
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-3">
                    <div class="card  ">
                        <div class="card-body">
                            <h3>Barbara Cartland</h3>
                            <p class="text-muted">Writer</p>
                            <p>Lorem ipsum dolor sit amet consectetur.</p> 
                        </div>
                    </div>
                </div>
                <div class="col-md-6 col-lg-3">
                    <div class="card  ">
                        <div class="card-body">
                            <h3>Alexander Pushkin</h3>
                            <p class="text-muted">Writer</p>
                            <p>Lorem ipsum dolor sit amet consectetur.</p> 
                        </div>
                    </div>
                </div>

            </div>    
        </div>
    </section>
     
    );
    }
  }
export default Autors;