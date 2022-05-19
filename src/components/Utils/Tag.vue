<template>
  <div class="tag-input">
    <div
      v-for="(tag, index) in tags"
      :key="tag"
      :index="index"
      class="tag-input__tag"
    >
      <span>x</span>
      {{ tag }}
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Tag",
  data() {
    return {
      tags: ["Híbrido", "Remoto", "Presencial"],
    };
  },
  methods: {
    removeTag(index: number) {
      this.tags.splice(index, 1);
    },
  },
});
</script>
<style scoped lang="scss">
.tag-input {
  width: 100%;
  font-size: 0.9em;
  margin: 0 1em 0;
  height: 1em;
  padding: 0 1em;
}

.tag-input__tag {
  height: 2em;
  float: left;
  margin-right: 10px;
  background-color: #E84616;
  color: #fff;
  font-weight: 500;
  line-height: 30px;
  padding: 0 1em 2em;
  border-radius: 6px;
}

.tag-input__tag > span {
  cursor: pointer;
  opacity: 0.75;
}

.tag-input__text {
  border: none;
  outline: none;
  font-size: 0.9em;
  line-height: 50px;
  background: none;
}
</style>
