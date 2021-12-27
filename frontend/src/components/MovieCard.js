import React, { useState, useEffect } from 'react';
import './css/MovieCard.css';

function MovieCard(props) {
    return (
        <div className="card movie-card">
            <img className="card-img-top" src={"https://"+props.imgSource} alt="Image failed loading.." />
            <div className="card-body">
                <p className="card-text">{props.title}</p>
                <p className="card-text">{props.year}</p>
            </div>
        </div>
    );
}

export default MovieCard;