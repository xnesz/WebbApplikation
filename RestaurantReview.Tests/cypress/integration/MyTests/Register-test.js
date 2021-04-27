/// <reference types="Cypress"/>

import { title } from "node:process";

describe('Register account'), () => {

    it('Registers a new account', () => {

        const username = 'visitor'
        const email = 'fake@email.com'
        const password = 'fakepassword123'


        cy.visit('http://localhost:4100')
        cy.contains('[data-cy=register').click()

        cy.location('pathname').should('equal', '/register')

        cy.get('[data-cy=username').type(username)
        cy.get('[data-cy=password').type(password)
        cy.get('[data-cy=confirmpassword').type(password)

        cy.get('[data-cy=email').type(email)

        cy.get('[data-cy=submitregistration').submit()

        cy.location('pathname').should('equal', '/index2')

    });

    it('Logs out', () => {

        cy.contains('[data-cy=profile').click()

        cy.location('pathname').should('equal', '/loggedin')

        cy.contains('.nav-link', 'Login').should('not.have.class', 'nav-link')

        cy.contains('[data-cy=logout').click()

        cy.location('pathname').should('equal', '/index')

        cy.contains('.nav-link', 'Login').should('have.class', 'nav-link')

    });

    it('Logs in', () => {

        cy.contains('[data-cy=login').click()

        cy.location('pathname').should('equal', '/login')

        cy.get('[data-cy=username').type(username)

        cy.get('[data-cy=password').type(password)


        cy.contains('[data-cy=submitlogin').click()

        cy.location('pathname').should('equal', '/index2')

    });

    it('Create a review', () => {


        const restaurant = 'ExampleRestaurant'
        const title = 'This is a review'
        const textbot = 'This is the main text'
        const rating = '5'


        cy.contains('[data-cy=writereview').click()

        cy.contains('[data-cy=searchrestaurant').type(restaurant)
        cy.contains('[data-cy=searchrestaurant').click()





       

    });








}