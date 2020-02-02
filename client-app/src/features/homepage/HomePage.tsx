import React from 'react'
import ButtonGroup from 'react-bootstrap/ButtonGroup'
import Button from 'react-bootstrap/Button';
import { Link } from 'react-router-dom';

const HomePage = () => {
    return (
        <div>
            <ButtonGroup aria-label="Basic example">
                <Button variant="secondary" as={Link} to='/addtask'>ADD TASK</Button>
                <Button variant="secondary">PROJECTS</Button>
                <Button variant="secondary">?</Button>
            </ButtonGroup>
        </div>
    )
}
export default HomePage;
