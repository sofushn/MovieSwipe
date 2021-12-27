import React, { useState, useEffect } from 'react';
import './css/GroupSection.css';
import './css/MenuSelection.css';

function MenuSelection(props) {
    return (
        <div>
            <h3 className='group-section-header'>Menu selection</h3>
            <ul class="nav flex-column group-section-nav">
                <li class="nav-item"><button type="button" class="btn btn-secondary menu-selection-btn">Swipe movies</button></li>
                <li class="nav-item"><button type="button" class="btn btn-secondary menu-selection-btn">See matched movies</button></li>
            </ul>
        </div>
    );
}

export default MenuSelection;