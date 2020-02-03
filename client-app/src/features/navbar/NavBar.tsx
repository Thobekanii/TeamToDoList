import React from 'react'
import Navbar from 'react-bootstrap/Navbar'
import { NavLink } from 'react-router-dom'
import {Container} from 'react-bootstrap'

const NavBar = () => {
    return (
        <Navbar bg="light" fixed='top'>
            <Container>
                <Navbar.Brand as={NavLink} to='/login'>Team To Do List</Navbar.Brand>
            </Container>
        </Navbar>
    )
}
export default NavBar;
