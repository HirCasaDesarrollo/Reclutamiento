import { createRouter, createWebHistory } from 'vue-router';
import Home from '../views/Home.vue'

const router = createRouter({
    history: createWebHistory(),
    routes: [
        {
            path: '/',
            component: Home
        },
        {
            path: '/progress',
            component: () => import('../views/Progress.vue')
        },
        {
            path: '/messages',
            component: () => import('../views/Messages.vue')
        },
        {
            path: '/settings',
            component: () => import('../views/SettingsPg.vue')
        }
    ]
})

export default router;