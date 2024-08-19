<script setup lang="ts">
import { RouterView } from 'vue-router'
import Headers from '../src/components/Header.vue'

const data = [
  { name: 'Home', value: 'home' },
  { name: 'About', value: 'about' }
]
</script>

<template>
  <Headers :data="data"></Headers>
  <RouterView />
</template>
