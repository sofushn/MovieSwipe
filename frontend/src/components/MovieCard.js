import React, { useState, useEffect } from 'react';
import './css/MovieCard.css';

function MovieCard(props) {
    return (
        <div className='container'>
            <div className='row justify-content-md-center movie-card-rows'>
                <div className="card movie-card">
                    <img className="card-img-top" src={"https://" + props.imgSource} alt="Image failed loading.." />
                    <div className="card-body">
                        <p className="card-text">{props.title}</p>
                        <p className="card-text">{props.year}</p>
                    </div>
                </div>
            </div>
            <div className='row movie-card-rows'>
                <div className='col'>
                    <div className='row justify-content-md-center'>
                        <button type="button" class="btn btn-danger">Dislike</button>
                    </div>
                </div>
                <div className='col'>
                    <div className='row justify-content-md-center'>
                        <button type="button" class="btn btn-success">Like</button>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default MovieCard;