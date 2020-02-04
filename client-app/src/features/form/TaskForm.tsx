import React from 'react'
import Form from 'react-bootstrap/Form'
import Button from 'react-bootstrap/Button'
import { DropdownButton, Dropdown, ListGroup, Container, Row, Col } from 'react-bootstrap';
import { DateTime } from 'react-datetime-bootstrap';


export const TaskForm = () => {
    return (
        <Container>
            <Row>
                <Col sm="8">
                    <Form>
                        <Form.Group controlId="exampleForm.ControlInput1">
                            <Form.Label>Assign To</Form.Label>
                            <Form.Control as="select">
                                <option>Thobekani</option>
                                <option>Sizwe</option>
                                <option>John</option>
                                <option>Blaine</option>
                                <option>Zulu</option>
                            </Form.Control>
                        </Form.Group>
                        <Form.Group controlId="exampleForm.ControlTextarea1">
                            <Form.Label>Task</Form.Label>
                            <Form.Control type="text" />
                        </Form.Group>
                        <Form.Group controlId="exampleForm.ControlSelect1">
                            <Form.Label>Project</Form.Label>
                            <Form.Control as="select">
                                <option>Billing System</option>
                                <option>Accounting System</option>
                                <option>Staff Salary</option>
                                <option>Sales Accounting</option>
                            </Form.Control>
                        </Form.Group>
                        <Form.Group controlId="exampleForm.ControlTextarea1">
                            <Form.Label>Start Date</Form.Label>
                            <Form.Control type="text" />
                        </Form.Group>
                        <Form.Group controlId="exampleForm.ControlTextarea1">
                            <Form.Label>Deadline</Form.Label>
                            <Form.Control type="DatetimePicker" />
                        </Form.Group>
                        <Form.Group controlId="exampleForm.ControlTextarea1">
                            <Form.Label>Description</Form.Label>
                            <Form.Control as="textarea" rows="3" />
                        </Form.Group>
                        <Form.Group controlId="exampleForm.ControlTextarea1">
                            <Form.Label>Comments</Form.Label>
                            <Form.Control as="textarea" rows="3" />
                        </Form.Group>

                        <Form.Group controlId="exampleForm.ControlTextarea1">
                            <Button variant="primary" type="submit">
                                Submit
  </Button>
                        </Form.Group>
                    </Form>
                </Col>
            </Row>
        </Container>)

}
export default TaskForm;