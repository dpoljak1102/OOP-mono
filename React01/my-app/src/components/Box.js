import React from 'react';


class Box extends React.Component {
    render() {
      return(
        <section class="bg-light py-5">
        <div class="container">
            <div class="col-12">
                <div class="info-header w-80">
                    <h1 class="text-silver">      
                        Most readed books
                    </h1>
                    <p class="lead">
                        Read a thousand books, and your words will flow like a river.
                    </p>
                </div>
            </div>
            
            <div class="py-5 row p-2">
                <div class="col-sm-3">
                    <div class="card text-light bg-dark">
                        <div class="card-body">
                            <h5 class="card-title ">Book1</h5>
                                <p class="card-text">
                                    Content
                                </p>
                        </div>
                    </div>
                </div>

                <div class="col-sm-3">
                    <div class="card text-light bg-dark">
                        <div class="card-body">
                            <h5 class="card-title">Book2</h5>
                                <p class="card-text">
                                    Content
                                </p>
                        </div>
                    </div>
                </div>

                <div class="col-sm-3">
                    <div class="card text-light bg-dark">
                        <div class="card-body">
                            <h5 class="card-title">Book3</h5>
                                <p class="card-text">
                                    Content
                                </p>
                        </div>
                    </div>
                </div>

                <div class="col-sm-3">
                    <div class="card text-light bg-dark">
                        <div class="card-body">
                            <h5 class="card-title">Book4</h5>
                                <p class="card-text">Content</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    );
    }
  }
export default Box;