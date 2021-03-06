import React from 'react'
import Form from 'react-bootstrap/Form'
import Button from 'react-bootstrap/Button'
import { DropdownButton, Dropdown, ListGroup, Accordion, Card, Container, Row, Col } from 'react-bootstrap'
import { DateTime } from 'react-datetime-bootstrap';


export const ProjectForm = () => {
    return (
        <Container>
            <Row>
                <Col sm="8">
                    <Form>
                        <Accordion>
                            <Card>
                                <Card.Header>
                                    <Accordion.Toggle as={Button} variant="link" eventKey="0">
                                        Active
      </Accordion.Toggle>
                                </Card.Header>
                                <Accordion.Collapse eventKey="0">
                                    <Card.Body>List of Projects</Card.Body>
                                </Accordion.Collapse>
                            </Card>
                            <Card>
                                <Card.Header>
                                    <Accordion.Toggle as={Button} variant="link" eventKey="1">
                                        Inactive
      </Accordion.Toggle>
                                </Card.Header>
                                <Accordion.Collapse eventKey="1">
                                    <Card.Body>List of Projects</Card.Body>
                                </Accordion.Collapse>
                            </Card>
                        </Accordion>
                    </Form>
                </Col>
            </Row>
        </Container>
    )

}
export default ProjectForm;