<template>
  <div class="app">
    <!-- Sidebar -->
    <Sidebar />
    <!-- Content -->
    <router-view />
  </div>
</template>

<script setup>
import Sidebar from './components/SideBar.vue'
</script>

<style lang="scss">
:root {
	--primary: #503E9D;
	--primary-alt: #6553B2;
	--grey: #64748b;
	--dark: #181B1A;
	--dark-alt: #FB6D3A;
	--light: #FFFFFF;
	--sidebar-width: 300px;
}

* {
	margin: 0;
	padding: 0;
	box-sizing: border-box;
	font-family: 'Fira sans', sans-serif;
}

body {
	background: var(--light);
}

button {
	cursor: pointer;
	appearance: none;
	border: none;
	outline: none;
	background: none;
}

.app {
	display: flex;

	main {
		flex: 1 1 0;
		padding: 2rem;

		@media (max-width: 1024px) {
			padding-left: 6rem;
		}
	}
}
</style>
