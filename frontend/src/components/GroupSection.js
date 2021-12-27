import React, { useState, useEffect } from 'react';
import './css/GroupSection.css';

function GroupSection(props) {
    return (
        <div>
            <h1 className='group-section-header'>SwipeNight</h1>
            <h3 className='group-section-header'>My groups</h3>
            <ul class="nav flex-column group-section-nav">
                <li class="nav-item"><a class="nav-link active" href="#">Group name 1</a></li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Group name 2</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Group name 3</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Group name 4</a>
                </li>
            </ul>
        </div>
    );
}

export default GroupSection;