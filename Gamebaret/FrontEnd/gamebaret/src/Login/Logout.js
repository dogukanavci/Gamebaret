import React, { useState } from 'react'
import './Auth.scss'
import { useDispatch,useSelector } from 'react-redux'
import { logout } from '../state/action-creator/index'
import { useHistory } from 'react-router-dom';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faSignOutAlt } from '@fortawesome/free-solid-svg-icons'

const Logout = () => {
    const dispatch = useDispatch()
    const history = useHistory();
    const user = useSelector(state => state.authReducer.user);
    let onLogout = () =>{
        dispatch(logout())
        history.push('/')
    }

    return (
        <div className="d-flex">
            <div>
                <p id="username" className="m-0">{user.username}</p>
                <FontAwesomeIcon className="c-pointer" onClick={onLogout} icon={faSignOutAlt} />
            </div>
        </div>
    );
}

export default Logout