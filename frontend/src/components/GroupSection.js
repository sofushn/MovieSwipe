import React, { useState, useEffect } from 'react';
import './css/GroupSection.css';

function GroupSection(props) {
    return (
        <div>
            <div className='row justify-content-md-center'>
                <div className='col'>
                    <h3 className='group-section-header-1'>
                        <img className='group-selection-popcorn-img' src="popcorn.png" width="30" height="30" alt="" />
                        SwipeNight
                    </h3>
                </div>
            </div>
            <div className='container-fluid group-section-container-1'>
                <h6 className='group-section-header-2'>MY GROUPS</h6>
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
            <div className='fixed-bottom'>
                Username <a>Logout</a>
            </div>
        </div>
    );
}

export default GroupSection;