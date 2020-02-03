import React from 'react'
import Navbar from 'react-bootstrap/Navbar'
import { NavLink, Link } from 'react-router-dom';
import { Container, Nav } from 'react-bootstrap'

const NavBar2 = () => {
    return (
        <Navbar>
            <Nav.Link href="/addtask" >ADD TASK</Nav.Link>
            <Nav.Link href="/">SEARCH TASKS</Nav.Link>
            <Nav.Link href="/projects">PROJECT</Nav.Link>
            <Navbar.Toggle />
            <Navbar.Collapse className="justify-content-end">
                <Navbar.Text>
                    Signed in as: <a href="#login">Thobekani</a>
                </Navbar.Text>
            </Navbar.Collapse>
        </Navbar>
    )
}
export default NavBar2;