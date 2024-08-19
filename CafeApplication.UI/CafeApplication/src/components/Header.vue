<template>
  <div class="grid grid-cols-1 bg-gray-700">
    <div class="col-span-1">
      <div class="flex flex-row justify-center gap-4 p-2">
        <div
          v-for="d in props.data"
          @click="onClickHeader(d.value)"
          class="bg-gray-500 p-2 text-gray-200 rounded-md border border-solid border-gray-600"
        >
          {{ d.name }}
        </div>
      </div>
    </div>
  </div>
</template>
<script setup lang="ts">
import type { PropType } from 'vue'
import router from '@/router'

const props = defineProps({
  data: Object as PropType<IProp[]>
})

function onClickHeader(val: string) {
  router.push(val)
}
interface IProp {
  name: string
  value: string
}
</script>
